using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm()
        {
            InitializeComponent();

            // CreateSampleData();
            LoadListData();

            WireUpLists();

        }

        private void LoadListData()
        {
            //availableTeamMembers = GlobalConfig.Connections().GetPerson_All();
            foreach (IDataConnection _data in GlobalConfig.Connections)
            {
                availableTeamMembers = _data.GetPerson_All();
            }
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "El", LastName = "Pepet" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Josep", LastName = "Pepet" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "ElSelected", LastName = "PepetSelected" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "JosepSelected", LastName = "PepetSelected" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel new_person = new PersonModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    cellphoneValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePerson(new_person);
                }

                selectedTeamMembers.Add(new_person);
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }


            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        
        }
    }
}
