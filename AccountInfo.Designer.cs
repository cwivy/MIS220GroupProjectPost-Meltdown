namespace MIS220GroupProject
{
    partial class AccountInfo
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
            this.goTo_DropBox = new System.Windows.Forms.ComboBox();
            this.billingHistory_BTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.birthDate_TXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateJoined_TXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zip_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.state_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.city_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address2_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address1_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_TXT = new System.Windows.Forms.TextBox();
            this.save_BTN = new System.Windows.Forms.Button();
            this.activeOrders_BTN = new System.Windows.Forms.Button();
            this.paymentType_LBL = new System.Windows.Forms.Label();
            this.memStatus_LBL = new System.Windows.Forms.Label();
            this.carNum_LBL = new System.Windows.Forms.Label();
            this.paymentType_TXT = new System.Windows.Forms.TextBox();
            this.memStatus_TXT = new System.Windows.Forms.TextBox();
            this.cardNum_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goTo_DropBox
            // 
            this.goTo_DropBox.FormattingEnabled = true;
            this.goTo_DropBox.Items.AddRange(new object[] {
            "Home",
            "Wish List",
            "Movie List",
            "Log Out"});
            this.goTo_DropBox.Location = new System.Drawing.Point(635, 3);
            this.goTo_DropBox.Name = "goTo_DropBox";
            this.goTo_DropBox.Size = new System.Drawing.Size(167, 24);
            this.goTo_DropBox.TabIndex = 63;
            this.goTo_DropBox.Text = "Go To:";
            // 
            // billingHistory_BTN
            // 
            this.billingHistory_BTN.Location = new System.Drawing.Point(343, 293);
            this.billingHistory_BTN.Name = "billingHistory_BTN";
            this.billingHistory_BTN.Size = new System.Drawing.Size(164, 76);
            this.billingHistory_BTN.TabIndex = 62;
            this.billingHistory_BTN.Text = "Billing History";
            this.billingHistory_BTN.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(424, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Birth Date:";
            // 
            // birthDate_TXT
            // 
            this.birthDate_TXT.Location = new System.Drawing.Point(577, 187);
            this.birthDate_TXT.Name = "birthDate_TXT";
            this.birthDate_TXT.Size = new System.Drawing.Size(225, 22);
            this.birthDate_TXT.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Date Joined:";
            // 
            // dateJoined_TXT
            // 
            this.dateJoined_TXT.Location = new System.Drawing.Point(577, 159);
            this.dateJoined_TXT.Name = "dateJoined_TXT";
            this.dateJoined_TXT.ReadOnly = true;
            this.dateJoined_TXT.Size = new System.Drawing.Size(225, 22);
            this.dateJoined_TXT.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Phone:";
            // 
            // phone_TXT
            // 
            this.phone_TXT.Location = new System.Drawing.Point(174, 239);
            this.phone_TXT.Name = "phone_TXT";
            this.phone_TXT.Size = new System.Drawing.Size(225, 22);
            this.phone_TXT.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Zipcode:";
            // 
            // zip_TXT
            // 
            this.zip_TXT.Location = new System.Drawing.Point(174, 211);
            this.zip_TXT.Name = "zip_TXT";
            this.zip_TXT.Size = new System.Drawing.Size(225, 22);
            this.zip_TXT.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "State:";
            // 
            // state_TXT
            // 
            this.state_TXT.Location = new System.Drawing.Point(174, 183);
            this.state_TXT.Name = "state_TXT";
            this.state_TXT.Size = new System.Drawing.Size(225, 22);
            this.state_TXT.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "City:";
            // 
            // city_TXT
            // 
            this.city_TXT.Location = new System.Drawing.Point(174, 155);
            this.city_TXT.Name = "city_TXT";
            this.city_TXT.Size = new System.Drawing.Size(225, 22);
            this.city_TXT.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Address 2:";
            // 
            // address2_TXT
            // 
            this.address2_TXT.Location = new System.Drawing.Point(174, 127);
            this.address2_TXT.Name = "address2_TXT";
            this.address2_TXT.Size = new System.Drawing.Size(225, 22);
            this.address2_TXT.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Address 1:";
            // 
            // address1_TXT
            // 
            this.address1_TXT.Location = new System.Drawing.Point(174, 99);
            this.address1_TXT.Name = "address1_TXT";
            this.address1_TXT.Size = new System.Drawing.Size(225, 22);
            this.address1_TXT.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Last Name:";
            // 
            // lastName_TXT
            // 
            this.lastName_TXT.Location = new System.Drawing.Point(174, 71);
            this.lastName_TXT.Name = "lastName_TXT";
            this.lastName_TXT.Size = new System.Drawing.Size(225, 22);
            this.lastName_TXT.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "First Name:";
            // 
            // firstName_TXT
            // 
            this.firstName_TXT.Location = new System.Drawing.Point(174, 43);
            this.firstName_TXT.Name = "firstName_TXT";
            this.firstName_TXT.Size = new System.Drawing.Size(225, 22);
            this.firstName_TXT.TabIndex = 42;
            // 
            // save_BTN
            // 
            this.save_BTN.Location = new System.Drawing.Point(530, 293);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.Size = new System.Drawing.Size(164, 76);
            this.save_BTN.TabIndex = 41;
            this.save_BTN.Text = "Save";
            this.save_BTN.UseVisualStyleBackColor = true;
            this.save_BTN.Click += new System.EventHandler(this.save_BTN_Click);
            // 
            // activeOrders_BTN
            // 
            this.activeOrders_BTN.Location = new System.Drawing.Point(158, 293);
            this.activeOrders_BTN.Name = "activeOrders_BTN";
            this.activeOrders_BTN.Size = new System.Drawing.Size(164, 76);
            this.activeOrders_BTN.TabIndex = 40;
            this.activeOrders_BTN.Text = "Active Orders";
            this.activeOrders_BTN.UseVisualStyleBackColor = true;
            // 
            // paymentType_LBL
            // 
            this.paymentType_LBL.AutoSize = true;
            this.paymentType_LBL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType_LBL.Location = new System.Drawing.Point(424, 130);
            this.paymentType_LBL.Name = "paymentType_LBL";
            this.paymentType_LBL.Size = new System.Drawing.Size(105, 17);
            this.paymentType_LBL.TabIndex = 39;
            this.paymentType_LBL.Text = "Payment Type:";
            // 
            // memStatus_LBL
            // 
            this.memStatus_LBL.AutoSize = true;
            this.memStatus_LBL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStatus_LBL.Location = new System.Drawing.Point(424, 103);
            this.memStatus_LBL.Name = "memStatus_LBL";
            this.memStatus_LBL.Size = new System.Drawing.Size(138, 17);
            this.memStatus_LBL.TabIndex = 38;
            this.memStatus_LBL.Text = "Membership Status:";
            // 
            // carNum_LBL
            // 
            this.carNum_LBL.AutoSize = true;
            this.carNum_LBL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNum_LBL.Location = new System.Drawing.Point(424, 79);
            this.carNum_LBL.Name = "carNum_LBL";
            this.carNum_LBL.Size = new System.Drawing.Size(100, 17);
            this.carNum_LBL.TabIndex = 37;
            this.carNum_LBL.Text = "Card Number:";
            // 
            // paymentType_TXT
            // 
            this.paymentType_TXT.Location = new System.Drawing.Point(577, 131);
            this.paymentType_TXT.Name = "paymentType_TXT";
            this.paymentType_TXT.Size = new System.Drawing.Size(225, 22);
            this.paymentType_TXT.TabIndex = 36;
            // 
            // memStatus_TXT
            // 
            this.memStatus_TXT.Location = new System.Drawing.Point(577, 103);
            this.memStatus_TXT.Name = "memStatus_TXT";
            this.memStatus_TXT.ReadOnly = true;
            this.memStatus_TXT.Size = new System.Drawing.Size(225, 22);
            this.memStatus_TXT.TabIndex = 35;
            // 
            // cardNum_TXT
            // 
            this.cardNum_TXT.Location = new System.Drawing.Point(577, 75);
            this.cardNum_TXT.Name = "cardNum_TXT";
            this.cardNum_TXT.Size = new System.Drawing.Size(225, 22);
            this.cardNum_TXT.TabIndex = 34;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 402);
            this.Controls.Add(this.goTo_DropBox);
            this.Controls.Add(this.billingHistory_BTN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.birthDate_TXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateJoined_TXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zip_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.state_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.city_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address2_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address1_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName_TXT);
            this.Controls.Add(this.save_BTN);
            this.Controls.Add(this.activeOrders_BTN);
            this.Controls.Add(this.paymentType_LBL);
            this.Controls.Add(this.memStatus_LBL);
            this.Controls.Add(this.carNum_LBL);
            this.Controls.Add(this.paymentType_TXT);
            this.Controls.Add(this.memStatus_TXT);
            this.Controls.Add(this.cardNum_TXT);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox goTo_DropBox;
        private System.Windows.Forms.Button billingHistory_BTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox birthDate_TXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dateJoined_TXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zip_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox state_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox city_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address2_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address1_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_TXT;
        private System.Windows.Forms.Button save_BTN;
        private System.Windows.Forms.Button activeOrders_BTN;
        private System.Windows.Forms.Label paymentType_LBL;
        private System.Windows.Forms.Label memStatus_LBL;
        private System.Windows.Forms.Label carNum_LBL;
        private System.Windows.Forms.TextBox paymentType_TXT;
        private System.Windows.Forms.TextBox memStatus_TXT;
        private System.Windows.Forms.TextBox cardNum_TXT;
    }
}