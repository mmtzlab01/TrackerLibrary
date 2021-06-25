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
        private List<PersonModel> availableTeamMembers = Globalconfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamform()
        {
            InitializeComponent();
            //CreateSampledata();
            WireUpLists();
        }
        private void CreateSampledata()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "tim", LastName = "smith" });
            availableTeamMembers.Add(new PersonModel { FirstName = "john", LastName = "doe" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "jane", LastName = "smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "jim", LastName = "jordan" });
        }
        private void WireUpLists()
        {
            SelectTeamDropdown.DataSource = null;

            SelectTeamDropdown.DataSource = availableTeamMembers;
            SelectTeamDropdown.DisplayMember = "FullName";

            TeamMembersListbox.DataSource = null;

            TeamMembersListbox.DataSource = selectedTeamMembers;
            TeamMembersListbox.DisplayMember = "FullName";
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

                p = Globalconfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                //SelectTeamDropdown.Refresh();
                //TeamMembersListbox.Refresh();
                WireUpLists();

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

        private void AddMemberbutton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamDropdown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                //SelectTeamDropdown.Refresh();
                //TeamMembersListbox.Refresh();

                WireUpLists(); 
            }
        }

        private void DeleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListbox.SelectedItem;


            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }

            
        }
    }
}
