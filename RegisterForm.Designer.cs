namespace project_k_i2
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnSignUp = new Button();
            cbShowPass = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(9, -32);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 508);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(32, 434);
            button1.Name = "button1";
            button1.Size = new Size(255, 35);
            button1.TabIndex = 13;
            button1.Text = "SIGN IN";
            button1.UseVisualStyleBackColor = false;
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SaddleBrown;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(52, 413);
            label4.Name = "label4";
            label4.Size = new Size(218, 18);
            label4.TabIndex = 10;
            label4.Text = "Already have an Account?";
            label4.Click += label4_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.SaddleBrown;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ButtonFace;
            btnSignUp.Location = new Point(399, 402);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(118, 35);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPass.Location = new Point(399, 368);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(143, 21);
            cbShowPass.TabIndex = 15;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(399, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(245, 26);
            txtPassword.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(399, 240);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(399, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(245, 26);
            txtUsername.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(399, 180);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 126);
            label1.Name = "label1";
            label1.Size = new Size(83, 22);
            label1.TabIndex = 10;
            label1.Text = "SIGN IN";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(399, 319);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(245, 26);
            txtConfirmPassword.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(402, 299);
            label6.Name = "label6";
            label6.Size = new Size(147, 17);
            label6.TabIndex = 17;
            label6.Text = "Confirm Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(720, 23);
            label7.Name = "label7";
            label7.Size = new Size(21, 22);
            label7.TabIndex = 19;
            label7.Text = "X";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 445);
            Controls.Add(label7);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btnSignUp);
            Controls.Add(cbShowPass);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnSignUp;
        private CheckBox cbShowPass;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label6;
        private Label label7;
    }
}