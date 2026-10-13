using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehabilitation_Records_System
{
    public partial class RehabilitationForm : Form
    {
        private string editingAnimalID;

        // Initialize the form and populate the animal grid when the application opens.
        public RehabilitationForm()
        {
            InitializeComponent();
            ConfigureAnimalGrid();
            RefreshAnimalGrid();
        }

        // Configure the grid to select complete records and prevent direct cell edits.
        private void ConfigureAnimalGrid()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Reload records from the text file and display them in the grid.
        private void RefreshAnimalGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FileHandler.LoadAnimals();
            string[] headers = { "Animal ID", "Name", "Species", "Age", "Recovery Score", "Status", "Housing Unit" };
            string[] properties = { "AnimalID", "Name", "Species", "Age", "RecoveryScore", "Status", "HousingUnit" };
            for (int column = 0; column < properties.Length; column++)
            {
                if (dataGridView1.Columns[properties[column]] != null)
                {
                    dataGridView1.Columns[properties[column]].HeaderText = headers[column];
                }
            }
        }

        // Copy an animal's values into the form and switch the controls to edit mode.
        private void LoadAnimalForEditing(Animal animal)
        {
            if (animal == null)
            {
                return;
            }

            editingAnimalID = animal.AnimalID;
            txtAnimalID.Text = animal.AnimalID;
            txtAnimalID.ReadOnly = true;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtScore.Text = animal.RecoveryScore.ToString();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        // Return the form to add mode and clear all input fields.
        private void ClearEditMode()
        {
            editingAnimalID = null;
            txtAnimalID.ReadOnly = false;
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        // Event handler for the Add button click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Try to add a new animal record
            try
            {
                // Retrieve input values from the text boxes
                string id = txtAnimalID.Text;
                string name = txtName.Text;
                string species = txtSpecies.Text;
                string ageText = txtAge.Text;
                string scoreText = txtScore.Text;

                // Validate the input values using the ExceptionHandler class
                ExceptionHandler.ValidateInput(
                    id, name, species, ageText, scoreText
                );

                // Parse the age and score values to integers
                int age = int.Parse(ageText);
                int score = int.Parse(scoreText);

                // Create a new Animal object with the validated input values
                Animal newAnimal = new Animal(id, name, species, age, score);

                // Append the new animal record to the file using the FileHandler class
                FileHandler.AppendAnimals(newAnimal);

                // Clear the input fields after successful addition
                MessageBox.Show($"Animal record added successfully ID: {newAnimal.AnimalID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Find an animal by an exact, case-insensitive ID and load it into the form.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string requestedID = txtSearchID.Text.Trim();
            Animal match = FileHandler.LoadAnimals().FirstOrDefault(animal =>
                string.Equals(animal.AnimalID, requestedID, StringComparison.OrdinalIgnoreCase));

            if (match == null)
            {
                MessageBox.Show("No animal was found with that ID.", "Animal not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadAnimalForEditing(match);
        }

        // Load the clicked grid row into the shared input fields.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].DataBoundItem == null)
            {
                return;
            }

            LoadAnimalForEditing(dataGridView1.Rows[e.RowIndex].DataBoundItem as Animal);
        }

        // Validate the edited fields, recalculate classification, and save only this record.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editingAnimalID))
            {
                MessageBox.Show("Select or search for an animal before saving changes.", "No animal selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ExceptionHandler.ValidateInput(txtAnimalID.Text, txtName.Text, txtSpecies.Text, txtAge.Text, txtScore.Text, false);
                Animal updatedAnimal = new Animal(txtAnimalID.Text, txtName.Text, txtSpecies.Text,
                    int.Parse(txtAge.Text.Trim()), int.Parse(txtScore.Text.Trim()));
                FileHandler.UpdateAnimal(editingAnimalID, updatedAnimal);
                RefreshAnimalGrid();
                ClearEditMode();
                MessageBox.Show("Animal record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "Unable to update animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel an edit and return the form to its empty add state.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEditMode();
        }
    }
}
