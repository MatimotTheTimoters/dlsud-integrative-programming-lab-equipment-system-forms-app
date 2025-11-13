using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEquipmentSystemForms.FormHelper
{
    public class MDIHelper
    {
        public static void LoadChildForm(Form newChildForm, Form parentForm)
        {
            CloseAllChildForms(parentForm);

            // Check if the form is already open
            foreach (Form childForm in parentForm.MdiChildren)
            {
                if (childForm.GetType() == newChildForm.GetType())
                {
                    // If the form is already open, activate it and return
                    childForm.Activate();
                    return;
                }
            }

            // If the form is not open, set it as a child of the parent form and show it
            newChildForm.MdiParent = parentForm;
            newChildForm.StartPosition = FormStartPosition.CenterScreen;
            newChildForm.Show();
        }

        private static void CloseAllChildForms(Form parentForm)
        {
            foreach (Form childForm in parentForm.MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
