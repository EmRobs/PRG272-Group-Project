using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehabilitation_Records_System
{
    public class Animal
    {
        // Properties for the Animal class
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; } 
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }

        // Constructor for the Animal class
        public Animal(string animalID, string name, string species, int age, int recoveryScore)
        {
            AnimalID = animalID.Trim().ToUpper();
            Name = name.Trim();
            Species = species.Trim();
            Age = age;
            RecoveryScore = recoveryScore;

            // Call the ClassifyAnimal method to determine the status and housing unit based on the recovery score
            ClassifyAnimal(recoveryScore, out string status, out string housingUnit);
            Status = status;
            HousingUnit = housingUnit;
        }

        //Classify the animal based on the recovery score and assign the appropriate status and housing unit
        public static void ClassifyAnimal(int score, out string status, out string housingUnit)
        {
            if (score >= 0 && score <= 19)
            {
                status = "Critical";
                housingUnit = "Intensive Care Unit";
            }
            else if (score >= 20 && score <= 39)
            {
                status = "Serious";
                housingUnit = "High-Dependency Ward";
            }
            else if (score >= 40 && score <= 59)
            {
                status = "Stable";
                housingUnit = "Recovery Ward";
            }
            else if (score >= 60 && score <= 79)
            {
                status = "Recovering";
                housingUnit = "Outdoor Enclosure";
            }
            else
            {
                status = "Release-Ready";
                housingUnit = "Pre-Release Camp";
            }
            
        }

        // Method to format the animal data for file storage
        public string FileFormat()
        {
            return $"{AnimalID} | {Name} | {Species} | {Age} | {RecoveryScore} | {Status} | {HousingUnit}";
        }
    }
}
