namespace Kioskieform
{
    partial class KIOSKIEFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KIOSKIEFORM));
            label1 = new Label();
            welcomelabel = new Label();
            welcomelabel2 = new Label();
            welcomelabel3 = new Label();
            welcomebutton1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1382, 62);
            label1.Margin = new Padding(11, 0, 11, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 23);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO MCDOLLIBEE\r\n";
            label1.Click += label1_Click;
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.BackColor = Color.Transparent;
            welcomelabel.Font = new Font("Arial Black", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelabel.ForeColor = Color.Gold;
            welcomelabel.Location = new Point(89, 97);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(440, 95);
            welcomelabel.TabIndex = 1;
            welcomelabel.Text = "WELCOME ";
            // 
            // welcomelabel2
            // 
            welcomelabel2.AutoSize = true;
            welcomelabel2.BackColor = Color.Red;
            welcomelabel2.Font = new Font("Arial Black", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelabel2.ForeColor = Color.Gold;
            welcomelabel2.Location = new Point(241, 192);
            welcomelabel2.Name = "welcomelabel2";
            welcomelabel2.Size = new Size(112, 74);
            welcomelabel2.TabIndex = 2;
            welcomelabel2.Text = "TO";
            welcomelabel2.Click += welcomelabel2_Click;
            // 
            // welcomelabel3
            // 
            welcomelabel3.AutoSize = true;
            welcomelabel3.Font = new Font("Arial Black", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelabel3.ForeColor = Color.Gold;
            welcomelabel3.Location = new Point(89, 266);
            welcomelabel3.Name = "welcomelabel3";
            welcomelabel3.Size = new Size(416, 74);
            welcomelabel3.TabIndex = 3;
            welcomelabel3.Text = "MCDOLLIBEE";
            // 
            // welcomebutton1
            // 
            welcomebutton1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomebutton1.Location = new Point(187, 409);
            welcomebutton1.Name = "welcomebutton1";
            welcomebutton1.Size = new Size(216, 41);
            welcomebutton1.TabIndex = 4;
            welcomebutton1.Text = "PRESS TO START";
            welcomebutton1.UseVisualStyleBackColor = true;
            welcomebutton1.Click += welcomebutton1_Click;
            // 
            // KIOSKIEFORM
            // 
            AutoScaleDimensions = new SizeF(26F, 52F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(600, 523);
            Controls.Add(welcomebutton1);
            Controls.Add(welcomelabel3);
            Controls.Add(welcomelabel2);
            Controls.Add(welcomelabel);
            Controls.Add(label1);
            Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(11, 10, 11, 10);
            Name = "KIOSKIEFORM";
            Text = "KIOSKIEFORM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label welcomelabel;
        private Label welcomelabel2;
        private Label welcomelabel3;
        private Button welcomebutton1;
    }
}
