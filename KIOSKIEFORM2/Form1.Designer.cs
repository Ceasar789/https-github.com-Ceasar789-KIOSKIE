namespace KIOSKIEFORM2
{
    partial class KIOSKIEFORM2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KIOSKIEFORM2));
            KIOSKIELABEL1 = new Label();
            KIOSKIELABEL2 = new Label();
            KIOSKIEBTN1 = new Button();
            KIOSKIEBTN2 = new Button();
            KIOSKIEBTN3 = new Button();
            KIOSKIEBTN4 = new Button();
            COMBOBOXMEALS = new ComboBox();
            KIOSKIEBTN5 = new Button();
            KIOSKIEBTN6 = new Button();
            KIOSKIELISTBOX = new ListBox();
            KIOSKIELABEL3 = new Label();
            KIOSKIEBTN7 = new Button();
            KIOSKIERBTN1 = new RadioButton();
            KIOSKIERBTN2 = new RadioButton();
            SuspendLayout();
            // 
            // KIOSKIELABEL1
            // 
            KIOSKIELABEL1.AutoSize = true;
            KIOSKIELABEL1.BackColor = Color.Red;
            KIOSKIELABEL1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIELABEL1.ForeColor = Color.Gold;
            KIOSKIELABEL1.Location = new Point(11, 9);
            KIOSKIELABEL1.Name = "KIOSKIELABEL1";
            KIOSKIELABEL1.Size = new Size(184, 52);
            KIOSKIELABEL1.TabIndex = 0;
            KIOSKIELABEL1.Text = "SELECT";
            // 
            // KIOSKIELABEL2
            // 
            KIOSKIELABEL2.AutoSize = true;
            KIOSKIELABEL2.BackColor = Color.ForestGreen;
            KIOSKIELABEL2.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIELABEL2.ForeColor = Color.Gold;
            KIOSKIELABEL2.Location = new Point(68, 61);
            KIOSKIELABEL2.Name = "KIOSKIELABEL2";
            KIOSKIELABEL2.Size = new Size(127, 45);
            KIOSKIELABEL2.TabIndex = 1;
            KIOSKIELABEL2.Text = "MENU";
            // 
            // KIOSKIEBTN1
            // 
            KIOSKIEBTN1.BackColor = Color.Red;
            KIOSKIEBTN1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN1.ForeColor = Color.Gold;
            KIOSKIEBTN1.Location = new Point(258, 17);
            KIOSKIEBTN1.Name = "KIOSKIEBTN1";
            KIOSKIEBTN1.Size = new Size(95, 89);
            KIOSKIEBTN1.TabIndex = 2;
            KIOSKIEBTN1.Text = "TipidMeals";
            KIOSKIEBTN1.UseVisualStyleBackColor = false;
            KIOSKIEBTN1.Click += KIOSKIEBTN1_Click;
            // 
            // KIOSKIEBTN2
            // 
            KIOSKIEBTN2.BackColor = Color.Red;
            KIOSKIEBTN2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN2.ForeColor = Color.Gold;
            KIOSKIEBTN2.Location = new Point(372, 17);
            KIOSKIEBTN2.Name = "KIOSKIEBTN2";
            KIOSKIEBTN2.Size = new Size(100, 89);
            KIOSKIEBTN2.TabIndex = 3;
            KIOSKIEBTN2.Text = "SuperMeals";
            KIOSKIEBTN2.UseVisualStyleBackColor = false;
            KIOSKIEBTN2.Click += KIOSKIEBTN2_Click;
            // 
            // KIOSKIEBTN3
            // 
            KIOSKIEBTN3.BackColor = Color.Red;
            KIOSKIEBTN3.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN3.ForeColor = Color.Gold;
            KIOSKIEBTN3.Location = new Point(493, 17);
            KIOSKIEBTN3.Name = "KIOSKIEBTN3";
            KIOSKIEBTN3.Size = new Size(95, 86);
            KIOSKIEBTN3.TabIndex = 4;
            KIOSKIEBTN3.Text = "SecretMeals";
            KIOSKIEBTN3.UseVisualStyleBackColor = false;
            KIOSKIEBTN3.Click += KIOSKIEBTN3_Click;
            // 
            // KIOSKIEBTN4
            // 
            KIOSKIEBTN4.BackColor = Color.Red;
            KIOSKIEBTN4.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN4.ForeColor = Color.Gold;
            KIOSKIEBTN4.Location = new Point(606, 17);
            KIOSKIEBTN4.Name = "KIOSKIEBTN4";
            KIOSKIEBTN4.Size = new Size(147, 86);
            KIOSKIEBTN4.TabIndex = 5;
            KIOSKIEBTN4.Text = "CustomizeMeal";
            KIOSKIEBTN4.UseVisualStyleBackColor = false;
            KIOSKIEBTN4.Click += button4_Click;
            // 
            // COMBOBOXMEALS
            // 
            COMBOBOXMEALS.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            COMBOBOXMEALS.FormattingEnabled = true;
            COMBOBOXMEALS.Location = new Point(241, 122);
            COMBOBOXMEALS.Name = "COMBOBOXMEALS";
            COMBOBOXMEALS.Size = new Size(512, 27);
            COMBOBOXMEALS.TabIndex = 6;
            COMBOBOXMEALS.SelectedIndexChanged += COMBOBOXMEALS_SelectedIndexChanged;
            // 
            // KIOSKIEBTN5
            // 
            KIOSKIEBTN5.BackColor = Color.LawnGreen;
            KIOSKIEBTN5.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN5.Location = new Point(4, 472);
            KIOSKIEBTN5.Name = "KIOSKIEBTN5";
            KIOSKIEBTN5.Size = new Size(158, 47);
            KIOSKIEBTN5.TabIndex = 7;
            KIOSKIEBTN5.Text = "ADD ORDER";
            KIOSKIEBTN5.UseVisualStyleBackColor = false;
            KIOSKIEBTN5.Click += KIOSKIEBTN5_Click;
            // 
            // KIOSKIEBTN6
            // 
            KIOSKIEBTN6.BackColor = Color.Tomato;
            KIOSKIEBTN6.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN6.Location = new Point(159, 472);
            KIOSKIEBTN6.Name = "KIOSKIEBTN6";
            KIOSKIEBTN6.Size = new Size(158, 76);
            KIOSKIEBTN6.TabIndex = 8;
            KIOSKIEBTN6.Text = "REMOVE ORDER";
            KIOSKIEBTN6.UseVisualStyleBackColor = false;
            KIOSKIEBTN6.Click += KIOSKIEBTN6_Click;
            // 
            // KIOSKIELISTBOX
            // 
            KIOSKIELISTBOX.FormattingEnabled = true;
            KIOSKIELISTBOX.ItemHeight = 15;
            KIOSKIELISTBOX.Location = new Point(4, 246);
            KIOSKIELISTBOX.Name = "KIOSKIELISTBOX";
            KIOSKIELISTBOX.Size = new Size(809, 229);
            KIOSKIELISTBOX.TabIndex = 9;
            KIOSKIELISTBOX.SelectedIndexChanged += KIOSKIELISTBOX_SelectedIndexChanged;
            // 
            // KIOSKIELABEL3
            // 
            KIOSKIELABEL3.AutoSize = true;
            KIOSKIELABEL3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIELABEL3.Location = new Point(4, 213);
            KIOSKIELABEL3.Name = "KIOSKIELABEL3";
            KIOSKIELABEL3.Size = new Size(164, 30);
            KIOSKIELABEL3.TabIndex = 10;
            KIOSKIELABEL3.Text = "ORDER CART";
            // 
            // KIOSKIEBTN7
            // 
            KIOSKIEBTN7.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIEBTN7.Location = new Point(314, 472);
            KIOSKIEBTN7.Name = "KIOSKIEBTN7";
            KIOSKIEBTN7.Size = new Size(158, 47);
            KIOSKIEBTN7.TabIndex = 11;
            KIOSKIEBTN7.Text = "CHECKOUT";
            KIOSKIEBTN7.UseVisualStyleBackColor = true;
            KIOSKIEBTN7.Click += KIOSKIEBTN7_Click;
            // 
            // KIOSKIERBTN1
            // 
            KIOSKIERBTN1.AutoSize = true;
            KIOSKIERBTN1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIERBTN1.Location = new Point(578, 165);
            KIOSKIERBTN1.Name = "KIOSKIERBTN1";
            KIOSKIERBTN1.Size = new Size(81, 22);
            KIOSKIERBTN1.TabIndex = 12;
            KIOSKIERBTN1.TabStop = true;
            KIOSKIERBTN1.Text = "DINE-IN";
            KIOSKIERBTN1.UseVisualStyleBackColor = true;
            KIOSKIERBTN1.CheckedChanged += KIOSKIERBTN1_CheckedChanged;
            // 
            // KIOSKIERBTN2
            // 
            KIOSKIERBTN2.AutoSize = true;
            KIOSKIERBTN2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KIOSKIERBTN2.Location = new Point(665, 165);
            KIOSKIERBTN2.Name = "KIOSKIERBTN2";
            KIOSKIERBTN2.Size = new Size(99, 22);
            KIOSKIERBTN2.TabIndex = 13;
            KIOSKIERBTN2.TabStop = true;
            KIOSKIERBTN2.Text = "TAKE-OUT";
            KIOSKIERBTN2.UseVisualStyleBackColor = true;
            KIOSKIERBTN2.CheckedChanged += KIOSKIERBTN2_CheckedChanged;
            // 
            // KIOSKIEFORM2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 547);
            Controls.Add(KIOSKIERBTN2);
            Controls.Add(KIOSKIERBTN1);
            Controls.Add(KIOSKIEBTN7);
            Controls.Add(KIOSKIELABEL3);
            Controls.Add(KIOSKIELISTBOX);
            Controls.Add(KIOSKIEBTN6);
            Controls.Add(KIOSKIEBTN5);
            Controls.Add(COMBOBOXMEALS);
            Controls.Add(KIOSKIEBTN4);
            Controls.Add(KIOSKIEBTN3);
            Controls.Add(KIOSKIEBTN2);
            Controls.Add(KIOSKIEBTN1);
            Controls.Add(KIOSKIELABEL2);
            Controls.Add(KIOSKIELABEL1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KIOSKIEFORM2";
            Text = "KIOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KIOSKIELABEL1;
        private Label KIOSKIELABEL2;
        private Button KIOSKIEBTN1;
        private Button KIOSKIEBTN2;
        private Button KIOSKIEBTN3;
        private Button KIOSKIEBTN4;
        private ComboBox COMBOBOXMEALS;
        private Button KIOSKIEBTN5;
        private Button KIOSKIEBTN6;
        private ListBox KIOSKIELISTBOX;
        private Label KIOSKIELABEL3;
        private Button KIOSKIEBTN7;
        private RadioButton KIOSKIERBTN1;
        private RadioButton KIOSKIERBTN2;
    }
}
