using System;
using System.Reflection;
using System.Windows.Forms;
using Aryoo.Forms;
using PaybarIranDoor.Modules.Controllers;
using RECORD = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;

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
            antbTransitEntrance.Select();
            antbTransitEntrance.Focus();
        }

        private void FillItems()
        {
            try
            {
                RECORD record = settingController.Get();
                if (record != null)
                {
                    antbTransitEntrance.Value = (int)record[1].Value;
                    antbTransitScan.Value = (int)record[2].Value;
                    antbTranshipmentEntrance.Value = (int)record[3].Value;
                    antbTranshipmentScan.Value = (int)record[4].Value;
                    antbTranshipmentTonage.Value = (int)record[5].Value;
                }
            }
            catch (Exception ex)
            {
                ExceptionController.LogError(ex, MethodInfo.GetCurrentMethod());
            }
        }

        protected override bool ValidateForm()
        {
            bool validate = base.ValidateForm();
            if (validate)
            {
                try
                {
                    if (!antbTransitEntrance.Validate())
                    {
                        tcSettings.SelectTab(0);
                        throw new ValidateException(antbTransitEntrance, "لطفا هزینه ورود ناوگان ایرانی را وارد نمایید");
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
                }
                catch
                {
                    validate = false;
                }
            }

            return validate;
        }

        private void OK()
        {
            try
            {
                if (ValidateForm())
                {
                    settingController.Edit(antbTransitEntrance.Value, antbTransitScan.Value, antbTranshipmentEntrance.Value, antbTranshipmentScan.Value, antbTranshipmentTonage.Value);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                ExceptionController.LogError(ex, MethodInfo.GetCurrentMethod());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK();
        }
    }
}
