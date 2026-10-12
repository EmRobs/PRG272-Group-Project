using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehabilitation_Records_System
{
    public partial class RehabilitationForm : Form
    {
        public RehabilitationForm()
        {
            InitializeComponent();
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
    }
}
