using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Business;
using Common;

namespace KIOSKIEFORM2
{
    public partial class KIOSKIEFORM2 : Form
    {
        string connectionString = "Data Source=DESKTOP-6GUPJLQ\\SQLEXPRESS;Initial Catalog=KIOSKIEDB;Integrated Security=True;TrustServerCertificate=True;";
        private readonly EmailService emailService;
        private string lastReceipt = "";

        public KIOSKIEFORM2()
        {
            InitializeComponent();
            KIOSKIELISTBOX.Font = new Font("Arial", 16, FontStyle.Bold);
            KIOSKIERBTN1.Checked = true;
            KIOSKIERBTN2.Checked = true;

            emailService = new EmailService();
            KIOSKIEBTN_EMAIL.Enabled = false;
            KIOSKIEBTN_EMAIL.Click += KIOSKIEBTN_EMAIL_Click;
        }

        private void KIOSKIEBTN1_Click(object sender, EventArgs e)
        {
            COMBOBOXMEALS.Items.Clear();
            COMBOBOXMEALS.Items.Add("Big Mac & Drinks P89");
            COMBOBOXMEALS.Items.Add("JollyHotdog & Drinks P79");
            COMBOBOXMEALS.Items.Add("Jolly Pares & Drinks P99");
        }

        private void KIOSKIEBTN2_Click(object sender, EventArgs e)
        {
            COMBOBOXMEALS.Items.Clear();
            COMBOBOXMEALS.Items.Add("Jolly Pares Overload P199");
            COMBOBOXMEALS.Items.Add("2pcs Chicken & Spag P200");
        }

        private void KIOSKIEBTN3_Click(object sender, EventArgs e)
        {
            COMBOBOXMEALS.Items.Clear();
            COMBOBOXMEALS.Items.Add("Whole Chicken Family Meal P499");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            COMBOBOXMEALS.Items.Clear();
            COMBOBOXMEALS.Items.Add("1pc Chicken & Drinks & Fries P99");
        }

        private void COMBOBOXMEALS_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"You selected: {COMBOBOXMEALS.SelectedItem}", "Meal Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KIOSKIEBTN5_Click(object sender, EventArgs e)
        {
            if (COMBOBOXMEALS.SelectedItem != null)
            {
                string selectedMeal = COMBOBOXMEALS.SelectedItem.ToString();
                string serviceType = "";

                if (KIOSKIERBTN1.Checked)
                    serviceType = "Dine In";
                else if (KIOSKIERBTN2.Checked)
                    serviceType = "Take Out";

                KIOSKIELISTBOX.Items.Add($"{selectedMeal} - {serviceType}");
            }
            else
            {
                MessageBox.Show("Please select a meal first.", "No Meal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KIOSKIEBTN6_Click(object sender, EventArgs e)
        {
            if (KIOSKIELISTBOX.SelectedItem != null)
                KIOSKIELISTBOX.Items.Remove(KIOSKIELISTBOX.SelectedItem);
            else
                MessageBox.Show("Please select an item to delete.", "No Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void KIOSKIEBTN7_Click(object sender, EventArgs e)
        {
            if (KIOSKIELISTBOX.Items.Count == 0)
            {
                MessageBox.Show("The order list is empty.", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string receipt = "\nRECEIPT\n\n";
            decimal total = 0;

            foreach (var item in KIOSKIELISTBOX.Items)
            {
                string order = item.ToString();
                receipt += order + "\n";

                int pIndex = order.IndexOf('P');
                if (pIndex != -1)
                {
                    string mealName = order.Substring(0, pIndex - 1).Trim();
                    string priceText = "";
                    for (int i = pIndex + 1; i < order.Length; i++)
                    {
                        if (char.IsDigit(order[i]) || order[i] == '.')
                            priceText += order[i];
                        else
                            break;
                    }
                    if (decimal.TryParse(priceText, out decimal price))
                    {
                        total += price;
                        string serviceType = order.Contains("Dine In") ? "Dine In" : "Take Out";
                        SaveOrderToDatabase(mealName, price, serviceType);
                    }
                }
            }

            string service = KIOSKIERBTN1.Checked ? "Dine In" : "Take Out";
            receipt += $"\nService: {service}\n";
            receipt += $"Total: P{total}\n";
            receipt += $"Date: {DateTime.Now}\n";

            lastReceipt = receipt;

            MessageBox.Show(receipt, "RECEIPT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KIOSKIEBTN_EMAIL.Enabled = true;
        }

        private void SaveOrderToDatabase(string mealName, decimal price, string serviceType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Orders (MealName, Price, ServiceType, OrderTime) VALUES (@MealName, @Price, @ServiceType, @OrderTime)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MealName", mealName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                    cmd.Parameters.AddWithValue("@OrderTime", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
        private void KIOSKIEBTN_EMAIL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastReceipt))
            {
                MessageBox.Show("No receipt found to send. Please checkout first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var email = new EmailMessage(
                "from@example.com",
                "to@example.com",
                "KIOSKIE Order Receipt",
                lastReceipt
            );

            string result = emailService.SendEmail(email);
            MessageBox.Show(result, "Email Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}