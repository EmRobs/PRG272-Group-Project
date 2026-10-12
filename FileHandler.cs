using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Rehabilitation_Records_System
{
    public static class FileHandler
    {
        // Define the file path for storing animal records
        private static string filePath = "animals.txt";

        // Load animal records from the file
        public static List<Animal> LoadAnimals()
        {
            List<Animal> animals = new List<Animal>();

            try 
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    return animals;
                }
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 7)
                        {
                            string animalID = parts[0].Trim();
                            string name = parts[1].Trim();
                            string species = parts[2].Trim();
                            int age = int.Parse(parts[3].Trim());
                            int recoveryScore = int.Parse(parts[4].Trim());
                            string status = parts[5].Trim();
                            string housingUnit = parts[6].Trim();

                            Animal animal = new Animal(animalID, name, species, age, recoveryScore);
                            animals.Add(animal);
                        }
                    }                            
            }
            catch 
            {
                MessageBox.Show("Error loading animals");
                return animals;
            }

            return animals;

        }

        // Save animal records to the file
        public static void AppendAnimals(Animal animals)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(animals.FileFormat());
                }
            }
            catch
            {
                MessageBox.Show("Error saving animals");
            }
        }

        // Save animal records to the file (overwrite existing records)
        public static void SaveAnimals(List<Animal> animals)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (var animal in animals)
                    {
                        writer.WriteLine(animal.FileFormat());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error saving animals");
            }
        }
    }
}
