using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PaybarIranDoor.Forms
{
    public partial class SettingsForm : DialogForm
    {
        private SettingController settingController;

        public SettingsForm()
        {
            InitializeComponent();
            SortByTabOrders();

            try
            {
                settingController = new SettingController();

                FillItems();
            }
            catch
            {
                settingController = null;
            }

            antbPrice.Select();
            antbPrice.Focus();
            atbHeader.OnSpecialKeyDown(AtbHeader_PreviewKeyDown);
        }

        private void FillItems()
        {
            try
            {
                AryooDataRow row = settingController.GetSettings();

                if (row != null)
                {
                    antbPrice.Value = (int)row["Price"];
                    atbFirstNo.Text = row["FirstNo"].ToString();
                    atbHeader.Text = row["Header"].ToString();
                }
            }
            catch (Exception ex)
            {
                ExceptionController.LogError(ex, System.Reflection.MethodInfo.GetCurrentMethod());
            }
        }

        protected override bool ValidateForm()
        {
            bool validate = base.ValidateForm();

            if (validate)
            {
                try
                {
                    if (!antbPrice.Validate())
                    {
                        tcSettings.SelectTab(0);

                        throw new ValidateException(antbPrice, "لطفا بهای هر لیتر را وارد نمایید");
                    }

                    if (!atbFirstNo.Validate())
                    {
                        tcSettings.SelectTab(0);

                        throw new ValidateException(atbFirstNo, "لطفا شماره اولیه قبض را وارد نمایید");
                    }

                    if (!atbHeader.Validate())
                    {
                        tcSettings.SelectTab(0);

                        throw new ValidateException(atbHeader, "لطفا عنوان جایگاه را وارد نمایید");
                    }

                    try
                    {
                        Int32.Parse(atbFirstNo.Text);
                    }
                    catch
                    {
                        tcSettings.SelectTab(0);

                        throw new ValidateException(atbFirstNo, "لطفا شماره اولیه قبض را به صورت صحیح وارد نمایید");
                    }
                }
                catch (ValidateException e)
                {
                    validate = false;
                    aErrorProvider.Text = e.Message;
                    e.Control.Select();

                    if (e.Control is AryooTextBox)
                    {
                        (e.Control as AryooTextBox).Blink();
                    }
                    else if (e.Control is AryooComboBox)
                    {
                        (e.Control as AryooComboBox).Blink();
                    }
                }
                catch
                {
                    validate = false;
                }
            }

            return validate;
        }

        #region Events

        private void OK()
        {
            try
            {
                if (ValidateForm())
                {
                    settingController.SetSettings(AryooString.MakePersian(atbHeader.Text), 0, atbFirstNo.Text, antbPrice.Value);

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                ExceptionController.LogError(ex, System.Reflection.MethodInfo.GetCurrentMethod());
            }
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void AtbHeader_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            OK();
        }
    }
}
