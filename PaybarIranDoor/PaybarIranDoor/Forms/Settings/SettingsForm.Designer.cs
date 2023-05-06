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
            this.tpTransit = new System.Windows.Forms.TabPage();
            this.aErrorProvider = new Aryoo.Forms.AryooErrorProvider();
            this.aryooLabel1 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel2 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel3 = new Aryoo.Forms.AryooLabel();
            this.antbTransitEntrance = new Aryoo.Forms.AryooNumericTextBox();
            this.tbTranshipment = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.aryooLabel5 = new Aryoo.Forms.AryooLabel();
            this.antbTransitScan = new Aryoo.Forms.AryooNumericTextBox();
            this.antbTranshipmentScan = new Aryoo.Forms.AryooNumericTextBox();
            this.aryooLabel4 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel6 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel7 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel8 = new Aryoo.Forms.AryooLabel();
            this.antbTranshipmentEntrance = new Aryoo.Forms.AryooNumericTextBox();
            this.antbTranshipmentTonage = new Aryoo.Forms.AryooNumericTextBox();
            this.aryooLabel9 = new Aryoo.Forms.AryooLabel();
            this.aryooLabel10 = new Aryoo.Forms.AryooLabel();
            this.tcSettings.SuspendLayout();
            this.tpTransit.SuspendLayout();
            this.tbTranshipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpTransit);
            this.tcSettings.Controls.Add(this.tbTranshipment);
            this.tcSettings.Font = new System.Drawing.Font("Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tcSettings.Location = new System.Drawing.Point(22, 43);
            this.tcSettings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcSettings.RightToLeftLayout = true;
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(863, 317);
            this.tcSettings.TabIndex = 1;
            // 
            // tpTransit
            // 
            this.tpTransit.BackColor = System.Drawing.Color.White;
            this.tpTransit.Controls.Add(this.antbTransitScan);
            this.tpTransit.Controls.Add(this.aryooLabel5);
            this.tpTransit.Controls.Add(this.aryooLabel1);
            this.tpTransit.Controls.Add(this.aryooLabel2);
            this.tpTransit.Controls.Add(this.aryooLabel3);
            this.tpTransit.Controls.Add(this.antbTransitEntrance);
            this.tpTransit.Location = new System.Drawing.Point(4, 59);
            this.tpTransit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpTransit.Name = "tpTransit";
            this.tpTransit.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpTransit.Size = new System.Drawing.Size(855, 254);
            this.tpTransit.TabIndex = 1;
            this.tpTransit.Text = "ترانزیت";
            // 
            // aErrorProvider
            // 
            this.aErrorProvider.BackColor = System.Drawing.Color.Transparent;
            this.aErrorProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.aErrorProvider.ErrorForeColor = System.Drawing.Color.Maroon;
            this.aErrorProvider.ErrorMessage = "";
            this.aErrorProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.aErrorProvider.GuideForeColor = System.Drawing.Color.Green;
            this.aErrorProvider.GuideMessage = "";
            this.aErrorProvider.Location = new System.Drawing.Point(0, 0);
            this.aErrorProvider.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.aErrorProvider.Name = "aErrorProvider";
            this.aErrorProvider.Size = new System.Drawing.Size(908, 31);
            this.aErrorProvider.TabIndex = 0;
            this.aErrorProvider.TabStop = false;
            // 
            // aryooLabel1
            // 
            this.aryooLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel1.AutoSize = true;
            this.aryooLabel1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel1.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel1.Location = new System.Drawing.Point(229, 59);
            this.aryooLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel1.Name = "aryooLabel1";
            this.aryooLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel1.Size = new System.Drawing.Size(68, 44);
            this.aryooLabel1.TabIndex = 2;
            this.aryooLabel1.Text = "ریال";
            // 
            // aryooLabel2
            // 
            this.aryooLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel2.AutoSize = true;
            this.aryooLabel2.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel2.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel2.Location = new System.Drawing.Point(538, 123);
            this.aryooLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel2.Name = "aryooLabel2";
            this.aryooLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel2.Size = new System.Drawing.Size(307, 44);
            this.aryooLabel2.TabIndex = 3;
            this.aryooLabel2.Text = "هزینه اسکن ناوگان ایرانی:";
            // 
            // aryooLabel3
            // 
            this.aryooLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel3.AutoSize = true;
            this.aryooLabel3.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel3.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel3.Location = new System.Drawing.Point(548, 57);
            this.aryooLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel3.Name = "aryooLabel3";
            this.aryooLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel3.Size = new System.Drawing.Size(297, 44);
            this.aryooLabel3.TabIndex = 0;
            this.aryooLabel3.Text = "هزینه ورود ناوگان ایرانی:";
            // 
            // antbTransitEntrance
            // 
            this.antbTransitEntrance.AllowInvalidNumber = true;
            this.antbTransitEntrance.AllowZero = false;
            this.antbTransitEntrance.BackColor = System.Drawing.Color.White;
            this.antbTransitEntrance.DisplayName = "هزینه ورود ناوگان ایرانی";
            this.antbTransitEntrance.ErrorProvider = this.aErrorProvider;
            this.antbTransitEntrance.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.antbTransitEntrance.ForceNotBlank = true;
            this.antbTransitEntrance.ForeColor = System.Drawing.Color.Black;
            this.antbTransitEntrance.HandleSpecialKey = false;
            this.antbTransitEntrance.InvalidNumberErrorMessage = "لطفا مقدار عددی وارد نمایید";
            this.antbTransitEntrance.Location = new System.Drawing.Point(324, 52);
            this.antbTransitEntrance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.antbTransitEntrance.MaxLength = 50;
            this.antbTransitEntrance.MoveByEnter = true;
            this.antbTransitEntrance.Name = "antbTransitEntrance";
            this.antbTransitEntrance.NotAllowZeroMessage = "لطفا مقدار بزرگتر از صفر وارد نمایید";
            this.antbTransitEntrance.NumberExceedMessage = "مقدار موجود خیلی بزرگ می باشد";
            this.antbTransitEntrance.PostFix = "";
            this.antbTransitEntrance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antbTransitEntrance.Size = new System.Drawing.Size(204, 51);
            this.antbTransitEntrance.SpecialKey = System.Windows.Forms.Keys.None;
            this.antbTransitEntrance.TabIndex = 1;
            this.antbTransitEntrance.Text = "0";
            this.antbTransitEntrance.Value = 0;
            // 
            // tbTranshipment
            // 
            this.tbTranshipment.BackColor = System.Drawing.Color.White;
            this.tbTranshipment.Controls.Add(this.antbTranshipmentTonage);
            this.tbTranshipment.Controls.Add(this.aryooLabel9);
            this.tbTranshipment.Controls.Add(this.aryooLabel10);
            this.tbTranshipment.Controls.Add(this.antbTranshipmentScan);
            this.tbTranshipment.Controls.Add(this.aryooLabel4);
            this.tbTranshipment.Controls.Add(this.aryooLabel6);
            this.tbTranshipment.Controls.Add(this.aryooLabel7);
            this.tbTranshipment.Controls.Add(this.aryooLabel8);
            this.tbTranshipment.Controls.Add(this.antbTranshipmentEntrance);
            this.tbTranshipment.Location = new System.Drawing.Point(4, 59);
            this.tbTranshipment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbTranshipment.Name = "tbTranshipment";
            this.tbTranshipment.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbTranshipment.Size = new System.Drawing.Size(855, 254);
            this.tbTranshipment.TabIndex = 2;
            this.tbTranshipment.Text = "تخلیه و بارگیری";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(332, 412);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOK.Size = new System.Drawing.Size(243, 63);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ثبت";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // aryooLabel5
            // 
            this.aryooLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel5.AutoSize = true;
            this.aryooLabel5.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel5.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel5.Location = new System.Drawing.Point(229, 123);
            this.aryooLabel5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel5.Name = "aryooLabel5";
            this.aryooLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel5.Size = new System.Drawing.Size(68, 44);
            this.aryooLabel5.TabIndex = 5;
            this.aryooLabel5.Text = "ریال";
            // 
            // antbTransitScan
            // 
            this.antbTransitScan.AllowInvalidNumber = true;
            this.antbTransitScan.AllowZero = false;
            this.antbTransitScan.BackColor = System.Drawing.Color.White;
            this.antbTransitScan.DisplayName = "بهای هر لیتر";
            this.antbTransitScan.ErrorProvider = this.aErrorProvider;
            this.antbTransitScan.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.antbTransitScan.ForceNotBlank = true;
            this.antbTransitScan.ForeColor = System.Drawing.Color.Black;
            this.antbTransitScan.HandleSpecialKey = false;
            this.antbTransitScan.InvalidNumberErrorMessage = "لطفا مقدار عددی وارد نمایید";
            this.antbTransitScan.Location = new System.Drawing.Point(324, 120);
            this.antbTransitScan.Margin = new System.Windows.Forms.Padding(5);
            this.antbTransitScan.MaxLength = 50;
            this.antbTransitScan.MoveByEnter = true;
            this.antbTransitScan.Name = "antbTransitScan";
            this.antbTransitScan.NotAllowZeroMessage = "لطفا مقدار بزرگتر از صفر وارد نمایید";
            this.antbTransitScan.NumberExceedMessage = "مقدار موجود خیلی بزرگ می باشد";
            this.antbTransitScan.PostFix = "";
            this.antbTransitScan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antbTransitScan.Size = new System.Drawing.Size(204, 51);
            this.antbTransitScan.SpecialKey = System.Windows.Forms.Keys.None;
            this.antbTransitScan.TabIndex = 4;
            this.antbTransitScan.Text = "0";
            this.antbTransitScan.Value = 0;
            // 
            // antbTranshipmentScan
            // 
            this.antbTranshipmentScan.AllowInvalidNumber = true;
            this.antbTranshipmentScan.AllowZero = false;
            this.antbTranshipmentScan.BackColor = System.Drawing.Color.White;
            this.antbTranshipmentScan.DisplayName = "بهای هر لیتر";
            this.antbTranshipmentScan.ErrorProvider = this.aErrorProvider;
            this.antbTranshipmentScan.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.antbTranshipmentScan.ForceNotBlank = true;
            this.antbTranshipmentScan.ForeColor = System.Drawing.Color.Black;
            this.antbTranshipmentScan.HandleSpecialKey = false;
            this.antbTranshipmentScan.InvalidNumberErrorMessage = "لطفا مقدار عددی وارد نمایید";
            this.antbTranshipmentScan.Location = new System.Drawing.Point(324, 120);
            this.antbTranshipmentScan.Margin = new System.Windows.Forms.Padding(5);
            this.antbTranshipmentScan.MaxLength = 50;
            this.antbTranshipmentScan.MoveByEnter = true;
            this.antbTranshipmentScan.Name = "antbTranshipmentScan";
            this.antbTranshipmentScan.NotAllowZeroMessage = "لطفا مقدار بزرگتر از صفر وارد نمایید";
            this.antbTranshipmentScan.NumberExceedMessage = "مقدار موجود خیلی بزرگ می باشد";
            this.antbTranshipmentScan.PostFix = "";
            this.antbTranshipmentScan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antbTranshipmentScan.Size = new System.Drawing.Size(204, 51);
            this.antbTranshipmentScan.SpecialKey = System.Windows.Forms.Keys.None;
            this.antbTranshipmentScan.TabIndex = 4;
            this.antbTranshipmentScan.Text = "0";
            this.antbTranshipmentScan.Value = 0;
            // 
            // aryooLabel4
            // 
            this.aryooLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel4.AutoSize = true;
            this.aryooLabel4.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel4.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel4.Location = new System.Drawing.Point(229, 123);
            this.aryooLabel4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel4.Name = "aryooLabel4";
            this.aryooLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel4.Size = new System.Drawing.Size(68, 44);
            this.aryooLabel4.TabIndex = 5;
            this.aryooLabel4.Text = "ریال";
            // 
            // aryooLabel6
            // 
            this.aryooLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel6.AutoSize = true;
            this.aryooLabel6.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel6.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel6.Location = new System.Drawing.Point(229, 59);
            this.aryooLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel6.Name = "aryooLabel6";
            this.aryooLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel6.Size = new System.Drawing.Size(68, 44);
            this.aryooLabel6.TabIndex = 2;
            this.aryooLabel6.Text = "ریال";
            // 
            // aryooLabel7
            // 
            this.aryooLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel7.AutoSize = true;
            this.aryooLabel7.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel7.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel7.Location = new System.Drawing.Point(538, 123);
            this.aryooLabel7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel7.Name = "aryooLabel7";
            this.aryooLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel7.Size = new System.Drawing.Size(307, 44);
            this.aryooLabel7.TabIndex = 3;
            this.aryooLabel7.Text = "هزینه اسکن ناوگان ایرانی:";
            // 
            // aryooLabel8
            // 
            this.aryooLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel8.AutoSize = true;
            this.aryooLabel8.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel8.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel8.Location = new System.Drawing.Point(548, 57);
            this.aryooLabel8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel8.Name = "aryooLabel8";
            this.aryooLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel8.Size = new System.Drawing.Size(297, 44);
            this.aryooLabel8.TabIndex = 0;
            this.aryooLabel8.Text = "هزینه ورود ناوگان ایرانی:";
            // 
            // antbTranshipmentEntrance
            // 
            this.antbTranshipmentEntrance.AllowInvalidNumber = true;
            this.antbTranshipmentEntrance.AllowZero = false;
            this.antbTranshipmentEntrance.BackColor = System.Drawing.Color.White;
            this.antbTranshipmentEntrance.DisplayName = "هزینه ورود ناوگان ایرانی";
            this.antbTranshipmentEntrance.ErrorProvider = this.aErrorProvider;
            this.antbTranshipmentEntrance.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.antbTranshipmentEntrance.ForceNotBlank = true;
            this.antbTranshipmentEntrance.ForeColor = System.Drawing.Color.Black;
            this.antbTranshipmentEntrance.HandleSpecialKey = false;
            this.antbTranshipmentEntrance.InvalidNumberErrorMessage = "لطفا مقدار عددی وارد نمایید";
            this.antbTranshipmentEntrance.Location = new System.Drawing.Point(324, 52);
            this.antbTranshipmentEntrance.Margin = new System.Windows.Forms.Padding(5);
            this.antbTranshipmentEntrance.MaxLength = 50;
            this.antbTranshipmentEntrance.MoveByEnter = true;
            this.antbTranshipmentEntrance.Name = "antbTranshipmentEntrance";
            this.antbTranshipmentEntrance.NotAllowZeroMessage = "لطفا مقدار بزرگتر از صفر وارد نمایید";
            this.antbTranshipmentEntrance.NumberExceedMessage = "مقدار موجود خیلی بزرگ می باشد";
            this.antbTranshipmentEntrance.PostFix = "";
            this.antbTranshipmentEntrance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antbTranshipmentEntrance.Size = new System.Drawing.Size(204, 51);
            this.antbTranshipmentEntrance.SpecialKey = System.Windows.Forms.Keys.None;
            this.antbTranshipmentEntrance.TabIndex = 1;
            this.antbTranshipmentEntrance.Text = "0";
            this.antbTranshipmentEntrance.Value = 0;
            // 
            // antbTranshipmentTonage
            // 
            this.antbTranshipmentTonage.AllowInvalidNumber = true;
            this.antbTranshipmentTonage.AllowZero = false;
            this.antbTranshipmentTonage.BackColor = System.Drawing.Color.White;
            this.antbTranshipmentTonage.DisplayName = "هزینه تناژ حمل یکسره";
            this.antbTranshipmentTonage.ErrorProvider = this.aErrorProvider;
            this.antbTranshipmentTonage.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.antbTranshipmentTonage.ForceNotBlank = true;
            this.antbTranshipmentTonage.ForeColor = System.Drawing.Color.Black;
            this.antbTranshipmentTonage.HandleSpecialKey = false;
            this.antbTranshipmentTonage.InvalidNumberErrorMessage = "لطفا مقدار عددی وارد نمایید";
            this.antbTranshipmentTonage.Location = new System.Drawing.Point(324, 192);
            this.antbTranshipmentTonage.Margin = new System.Windows.Forms.Padding(5);
            this.antbTranshipmentTonage.MaxLength = 50;
            this.antbTranshipmentTonage.MoveByEnter = true;
            this.antbTranshipmentTonage.Name = "antbTranshipmentTonage";
            this.antbTranshipmentTonage.NotAllowZeroMessage = "لطفا مقدار بزرگتر از صفر وارد نمایید";
            this.antbTranshipmentTonage.NumberExceedMessage = "مقدار موجود خیلی بزرگ می باشد";
            this.antbTranshipmentTonage.PostFix = "";
            this.antbTranshipmentTonage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antbTranshipmentTonage.Size = new System.Drawing.Size(204, 51);
            this.antbTranshipmentTonage.SpecialKey = System.Windows.Forms.Keys.None;
            this.antbTranshipmentTonage.TabIndex = 7;
            this.antbTranshipmentTonage.Text = "0";
            this.antbTranshipmentTonage.Value = 0;
            // 
            // aryooLabel9
            // 
            this.aryooLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel9.AutoSize = true;
            this.aryooLabel9.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel9.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel9.Location = new System.Drawing.Point(229, 195);
            this.aryooLabel9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel9.Name = "aryooLabel9";
            this.aryooLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel9.Size = new System.Drawing.Size(68, 44);
            this.aryooLabel9.TabIndex = 8;
            this.aryooLabel9.Text = "ریال";
            // 
            // aryooLabel10
            // 
            this.aryooLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aryooLabel10.AutoSize = true;
            this.aryooLabel10.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aryooLabel10.ForeColor = System.Drawing.Color.Black;
            this.aryooLabel10.Location = new System.Drawing.Point(573, 195);
            this.aryooLabel10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aryooLabel10.Name = "aryooLabel10";
            this.aryooLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aryooLabel10.Size = new System.Drawing.Size(272, 44);
            this.aryooLabel10.TabIndex = 6;
            this.aryooLabel10.Text = "هزینه تناژ حمل یکسره:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 494);
            this.CloseOnEsc = true;
            this.Controls.Add(this.aErrorProvider);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tcSettings);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SettingsForm";
            this.Text = "تنظیمات";
            this.TopMost = true;
            this.tcSettings.ResumeLayout(false);
            this.tpTransit.ResumeLayout(false);
            this.tpTransit.PerformLayout();
            this.tbTranshipment.ResumeLayout(false);
            this.tbTranshipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpTransit;
        private Aryoo.Forms.AryooLabel aryooLabel2;
        private Aryoo.Forms.AryooLabel aryooLabel3;
        private Aryoo.Forms.AryooNumericTextBox antbTransitEntrance;
        private System.Windows.Forms.TabPage tbTranshipment;
        private System.Windows.Forms.Button btnOK;
        private Aryoo.Forms.AryooErrorProvider aErrorProvider;
        private Aryoo.Forms.AryooLabel aryooLabel1;
        private Aryoo.Forms.AryooLabel aryooLabel5;
        private Aryoo.Forms.AryooNumericTextBox antbTransitScan;
        private Aryoo.Forms.AryooNumericTextBox antbTranshipmentScan;
        private Aryoo.Forms.AryooLabel aryooLabel4;
        private Aryoo.Forms.AryooLabel aryooLabel6;
        private Aryoo.Forms.AryooLabel aryooLabel7;
        private Aryoo.Forms.AryooLabel aryooLabel8;
        private Aryoo.Forms.AryooNumericTextBox antbTranshipmentEntrance;
        private Aryoo.Forms.AryooNumericTextBox antbTranshipmentTonage;
        private Aryoo.Forms.AryooLabel aryooLabel9;
        private Aryoo.Forms.AryooLabel aryooLabel10;
    }
}