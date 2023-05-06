namespace PaybarIranDoor.Forms
{
    partial class SettingsForm
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
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.atbHeader = new Aryoo.Forms.AryooTextBox();
            this.aErrorProvider = new Aryoo.Forms.AryooErrorProvider();
            this.aryooLabel5 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel1 = new Aryoo.Forms.AryooLabel();
            this.atbFirstNo = new Aryoo.Forms.AryooTextBox();
            this.aryooLabel2 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel3 = new Aryoo.Forms.AryooLabel();
            this.antbPrice = new Aryoo.Forms.AryooNumericTextBox();
            this.tbAdvanced = new System.Windows.Forms.TabPage();
            this.aryooLabel4 = new Aryoo.Forms.AryooLabel();
            this.atbServerIp = new Aryoo.Forms.AryooTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tbAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tbAdvanced);
            this.tcSettings.Font = new System.Drawing.Font("Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tcSettings.Location = new System.Drawing.Point(13, 28);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcSettings.RightToLeftLayout = true;
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(518, 206);
            this.tcSettings.TabIndex = 1;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.Color.White;
            this.tpGeneral.Controls.Add(this.atbHeader);
            this.tpGeneral.Controls.Add(this.aryooLabel5);
            this.tpGeneral.Controls.Add(this.aryooLabel1);
            this.tpGeneral.Controls.Add(this.atbFirstNo);
            this.tpGeneral.Controls.Add(this.aryooLabel2);
            this.tpGeneral.Controls.Add(this.aryooLabel3);
            this.tpGeneral.Controls.Add(this.antbPrice);
            this.tpGeneral.Location = new System.Drawing.Point(4, 42);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(510, 160);
            this.tpGeneral.TabIndex = 1;
            this.tpGeneral.Text = "عمومی";
            // 
            // atbHeader
            // 
            this.atbHeader.BackColor = System.Drawing.Color.White;
            this.atbHeader.DisplayName = "عوان جایگاه";
            this.atbHeader.ErrorProvider = this.aErrorProvider;
            this.atbHeader.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.atbHeader.ForceNotBlank = true;
            this.atbHeader.ForeColor = System.Drawing.Color.Black;
            this.atbHeader.HandleSpecialKey = true;
            this.atbHeader.Location = new System.Drawing.Point(6, 111);
            this.atbHeader.MaxLength = 50;
            this.atbHeader.MoveByEnter = false;
            this.atbHeader.Name = "atbHeader";
            this.atbHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.atbHeader.Size = new System.Drawing.Size(354, 37);
            this.atbHeader.SpecialKey = System.Windows.Forms.Keys.Return;
            this.atbHeader.TabIndex = 6;
            // 
            // aErrorProvider
            // 
            this.aErrorProvider.BackColor = System.Drawing.Color.Transparent;
            this.aErrorProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.aErrorProvider.ErrorForeColor = System.Drawing.Color.Maroon;
            this.aErrorProvider.ErrorMessage = "";
            this.aErrorProvider.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.aErrorProvider.GuideForeColor = System.Drawing.Color.Green;
            this.aErrorProvider.GuideMessage = "";
            this.aErrorProvider.Location = new System.Drawing.Point(0, 0);
            this.aErrorProvider.Name = "aErrorProvider";
            this.aErrorProvider.Size = new System.Drawing.Size(545, 20);
            this.aErrorProvider.TabIndex = 0;
            this.aErrorProvider.TabStop = false;
            // 
            // aryooLabel5
            // 
            this.aryooLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel5.AutoSize = true;
            this.aryooLabel5.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel5.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel5.Location = new System.Drawing.Point(400, 115);
            this.aryooLabel5.Name = "aryooLabel5";
            this.aryooLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel5.Size = new System.Drawing.Size(104, 29);
            this.aryooLabel5.TabIndex = 5;
            this.aryooLabel5.Text = "عنوان جايگاه:";
            // 
            // aryooLabel1
            // 
            this.aryooLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel1.AutoSize = true;
            this.aryooLabel1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel1.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel1.Location = new System.Drawing.Point(179, 29);
            this.aryooLabel1.Name = "aryooLabel1";
            this.aryooLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel1.Size = new System.Drawing.Size(51, 29);
            this.aryooLabel1.TabIndex = 2;
            this.aryooLabel1.Text = "تومان";
            // 
            // atbFirstNo
            // 
            this.atbFirstNo.BackColor = System.Drawing.Color.White;
            this.atbFirstNo.DisplayName = "شماره اولیه قبض";
            this.atbFirstNo.ErrorProvider = this.aErrorProvider;
            this.atbFirstNo.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.atbFirstNo.ForceNotBlank = false;
            this.atbFirstNo.ForeColor = System.Drawing.Color.Black;
            this.atbFirstNo.HandleSpecialKey = false;
            this.atbFirstNo.Location = new System.Drawing.Point(236, 69);
            this.atbFirstNo.MaxLength = 50;
            this.atbFirstNo.MoveByEnter = true;
            this.atbFirstNo.Name = "atbFirstNo";
            this.atbFirstNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.atbFirstNo.Size = new System.Drawing.Size(124, 37);
            this.atbFirstNo.SpecialKey = System.Windows.Forms.Keys.None;
            this.atbFirstNo.TabIndex = 4;
            // 
            // aryooLabel2
            // 
            this.aryooLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel2.AutoSize = true;
            this.aryooLabel2.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel2.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel2.Location = new System.Drawing.Point(366, 72);
            this.aryooLabel2.Name = "aryooLabel2";
            this.aryooLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel2.Size = new System.Drawing.Size(138, 29);
            this.aryooLabel2.TabIndex = 3;
            this.aryooLabel2.Text = "شماره اولیه قبض:";
            // 
            // aryooLabel3
            // 
            this.aryooLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel3.AutoSize = true;
            this.aryooLabel3.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel3.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel3.Location = new System.Drawing.Point(404, 29);
            this.aryooLabel3.Name = "aryooLabel3";
            this.aryooLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel3.Size = new System.Drawing.Size(100, 29);
            this.aryooLabel3.TabIndex = 0;
            this.aryooLabel3.Text = "بهای هر لیتر:";
            // 
            // antbPrice
            // 
            this.antbPrice.AllowInvalidNumber = true;
            this.antbPrice.AllowZero = false;
            this.antbPrice.BackColor = System.Drawing.Color.White;
            this.antbPrice.DisplayName = "بهای هر لیتر";
            this.antbPrice.ErrorProvider = this.aErrorProvider;
            this.antbPrice.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.antbPrice.ForceNotBlank = true;
            this.antbPrice.ForeColor = System.Drawing.Color.Black;
            this.antbPrice.HandleSpecialKey = false;
            this.antbPrice.InvalidNumberErrorMessage = "لطفا مقدار عددی وارد نمایید";
            this.antbPrice.Location = new System.Drawing.Point(236, 25);
            this.antbPrice.MaxLength = 50;
            this.antbPrice.MoveByEnter = true;
            this.antbPrice.Name = "antbPrice";
            this.antbPrice.NotAllowZeroMessage = "لطفا مقدار بزرگتر از صفر وارد نمایید";
            this.antbPrice.NumberExceedMessage = "مقدار موجود خیلی بزرگ می باشد";
            this.antbPrice.PostFix = "";
            this.antbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antbPrice.Size = new System.Drawing.Size(124, 37);
            this.antbPrice.SpecialKey = System.Windows.Forms.Keys.None;
            this.antbPrice.TabIndex = 1;
            this.antbPrice.Text = "0";
            this.antbPrice.Value = 0;
            // 
            // tbAdvanced
            // 
            this.tbAdvanced.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbAdvanced.Controls.Add(this.aryooLabel4);
            this.tbAdvanced.Controls.Add(this.atbServerIp);
            this.tbAdvanced.Location = new System.Drawing.Point(4, 42);
            this.tbAdvanced.Name = "tbAdvanced";
            this.tbAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdvanced.Size = new System.Drawing.Size(510, 160);
            this.tbAdvanced.TabIndex = 2;
            this.tbAdvanced.Text = "پيشرفته";
            // 
            // aryooLabel4
            // 
            this.aryooLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel4.AutoSize = true;
            this.aryooLabel4.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel4.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel4.Location = new System.Drawing.Point(401, 30);
            this.aryooLabel4.Name = "aryooLabel4";
            this.aryooLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel4.Size = new System.Drawing.Size(103, 29);
            this.aryooLabel4.TabIndex = 0;
            this.aryooLabel4.Text = "آدرس سرور:";
            // 
            // atbServerIp
            // 
            this.atbServerIp.BackColor = System.Drawing.Color.White;
            this.atbServerIp.DisplayName = "آدرس سرور";
            this.atbServerIp.ErrorProvider = this.aErrorProvider;
            this.atbServerIp.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.atbServerIp.ForceNotBlank = false;
            this.atbServerIp.ForeColor = System.Drawing.Color.Black;
            this.atbServerIp.HandleSpecialKey = false;
            this.atbServerIp.Location = new System.Drawing.Point(6, 27);
            this.atbServerIp.MaxLength = 50;
            this.atbServerIp.MoveByEnter = true;
            this.atbServerIp.Name = "atbServerIp";
            this.atbServerIp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.atbServerIp.Size = new System.Drawing.Size(389, 37);
            this.atbServerIp.SpecialKey = System.Windows.Forms.Keys.None;
            this.atbServerIp.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(199, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOK.Size = new System.Drawing.Size(146, 41);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ثبت";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 321);
            this.CloseOnEsc = true;
            this.Controls.Add(this.aErrorProvider);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tcSettings);
            this.KeyPreview = true;
            this.Name = "SettingsForm";
            this.Text = "تنظیمات";
            this.TopMost = true;
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tbAdvanced.ResumeLayout(false);
            this.tbAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private Aryoo.Forms.AryooTextBox atbFirstNo;
        private Aryoo.Forms.AryooLabel aryooLabel2;
        private Aryoo.Forms.AryooLabel aryooLabel3;
        private Aryoo.Forms.AryooNumericTextBox antbPrice;
        private System.Windows.Forms.TabPage tbAdvanced;
        private Aryoo.Forms.AryooLabel aryooLabel4;
        private Aryoo.Forms.AryooTextBox atbServerIp;
        private System.Windows.Forms.Button btnOK;
        private Aryoo.Forms.AryooErrorProvider aErrorProvider;
        private Aryoo.Forms.AryooLabel aryooLabel1;
        private Aryoo.Forms.AryooTextBox atbHeader;
        private Aryoo.Forms.AryooLabel aryooLabel5;
    }
}