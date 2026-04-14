namespace project_k_i2
{
    partial class Form1
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
            panel1 = new Panel();
            btnLoginRegister = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblX = new Label();
            label1 = new Label();
            label2 = new Label();
            txtLoginUsername = new TextBox();
            txtLoginPassword = new TextBox();
            label3 = new Label();
            cbLoginShow = new CheckBox();
            btnLoginLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(btnLoginRegister);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-12, -56);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 508);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLoginRegister
            // 
            btnLoginRegister.BackColor = Color.SaddleBrown;
            btnLoginRegister.FlatStyle = FlatStyle.Flat;
            btnLoginRegister.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginRegister.ForeColor = SystemColors.ButtonFace;
            btnLoginRegister.Location = new Point(43, 454);
            btnLoginRegister.Name = "btnLoginRegister";
            btnLoginRegister.Size = new Size(255, 35);
            btnLoginRegister.TabIndex = 13;
            btnLoginRegister.Text = "REGISTER";
            btnLoginRegister.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 232);
            label5.Name = "label5";
            label5.Size = new Size(300, 22);
            label5.TabIndex = 12;
            label5.Text = "Cafe Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2ffbdcdf421e37ff00b84643913c9e18;
            pictureBox1.Location = new Point(121, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SaddleBrown;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(87, 431);
            label4.Name = "label4";
            label4.Size = new Size(159, 18);
            label4.TabIndex = 10;
            label4.Text = "Create an Account";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblX.Location = new Point(642, 9);
            lblX.Name = "lblX";
            lblX.Size = new Size(18, 18);
            lblX.TabIndex = 1;
            lblX.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 102);
            label1.Name = "label1";
            label1.Size = new Size(83, 22);
            label1.TabIndex = 2;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(378, 156);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginUsername.Location = new Point(378, 176);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(245, 26);
            txtLoginUsername.TabIndex = 4;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPassword.Location = new Point(378, 236);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(245, 26);
            txtLoginPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(378, 216);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // cbLoginShow
            // 
            cbLoginShow.AutoSize = true;
            cbLoginShow.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLoginShow.Location = new Point(378, 268);
            cbLoginShow.Name = "cbLoginShow";
            cbLoginShow.Size = new Size(143, 21);
            cbLoginShow.TabIndex = 7;
            cbLoginShow.Text = "Show Password";
            cbLoginShow.UseVisualStyleBackColor = true;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.SaddleBrown;
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginLogin.ForeColor = SystemColors.ButtonFace;
            btnLoginLogin.Location = new Point(520, 305);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(118, 35);
            btnLoginLogin.TabIndex = 8;
            btnLoginLogin.Text = "LOGIN";
            btnLoginLogin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(672, 445);
            Controls.Add(btnLoginLogin);
            Controls.Add(cbLoginShow);
            Controls.Add(txtLoginPassword);
            Controls.Add(label3);
            Controls.Add(txtLoginUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblX);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblX;
        private Label label1;
        private Label label2;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
        private Label label3;
        private CheckBox cbLoginShow;
        private Label label4;
        private Button btnLoginLogin;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnLoginRegister;
    }
}
