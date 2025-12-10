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
            // Check if the form is already open
            foreach (Form childForm in parentForm.MdiChildren)
            {
                if (childForm.GetType() == newChildForm.GetType())
                {
                    // If the form is already open, activate it and return
                    childForm.Activate();
                    childForm.BringToFront();
                    newChildForm.Dispose();
                    return;
                }
            }

            SetChildFormProperties(newChildForm, parentForm);
            newChildForm.Show();
        }

        private static void CloseAllChildForms(Form parentForm)
        {
            foreach (Form childForm in parentForm.MdiChildren)
            {
                childForm.Dispose();
            }
        }

        private static void SetChildFormProperties(Form childForm, Form parentForm)
        {
            childForm.MdiParent = parentForm;

            childForm.WindowState = FormWindowState.Maximized;
            childForm.StartPosition = FormStartPosition.CenterScreen;

            childForm.ControlBox = false;
            childForm.MaximizeBox = false;
            childForm.MinimizeBox = false;

            childForm.ShowIcon = false;
            childForm.ShowInTaskbar = false;
        }
    }
}
