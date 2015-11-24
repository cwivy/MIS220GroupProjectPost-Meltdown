namespace MIS220GroupProject
{
    partial class LoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUserBox = new System.Windows.Forms.TextBox();
            this.loginPassBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createAccount_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.login_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // loginUserBox
            // 
            this.loginUserBox.Location = new System.Drawing.Point(164, 91);
            this.loginUserBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginUserBox.Name = "loginUserBox";
            this.loginUserBox.Size = new System.Drawing.Size(76, 20);
            this.loginUserBox.TabIndex = 1;
            // 
            // loginPassBox
            // 
            this.loginPassBox.Location = new System.Drawing.Point(164, 112);
            this.loginPassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(76, 20);
            this.loginPassBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Don\'t have an account? -->";
            // 
            // createAccount_BTN
            // 
            this.createAccount_BTN.Location = new System.Drawing.Point(256, 194);
            this.createAccount_BTN.Name = "createAccount_BTN";
            this.createAccount_BTN.Size = new System.Drawing.Size(108, 23);
            this.createAccount_BTN.TabIndex = 4;
            this.createAccount_BTN.Text = "Create Account";
            this.createAccount_BTN.UseVisualStyleBackColor = true;
            this.createAccount_BTN.Click += new System.EventHandler(this.createAccount_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome to DVD Express!";
            // 
            // login_BTN
            // 
            this.login_BTN.Location = new System.Drawing.Point(164, 137);
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.Size = new System.Drawing.Size(75, 23);
            this.login_BTN.TabIndex = 3;
            this.login_BTN.Text = "Login";
            this.login_BTN.UseVisualStyleBackColor = true;
            this.login_BTN.Click += new System.EventHandler(this.login_BTN_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 248);
            this.Controls.Add(this.login_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createAccount_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginPassBox);
            this.Controls.Add(this.loginUserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUserBox;
        private System.Windows.Forms.TextBox loginPassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createAccount_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_BTN;
    }
}