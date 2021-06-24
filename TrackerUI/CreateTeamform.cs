using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeamform : Form
    {
        public CreateTeamform()
        {
            InitializeComponent();
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.CellPhoneNumber = PhoneValue.Text;

                Globalconfig.Connection.CreatePerson(p);

                Clearform();

            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private void Clearform()
        {
            FirstNameValue.Text = "";
            LastNameValue.Text = "";
            EmailValue.Text = "";
            PhoneValue.Text = "";

        }

        private bool Validateform()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (EmailValue.Text.Length == 0)
            {
                return false;
            }
            if (PhoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
