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
    public class FileHandler
    {
        // Define the file path for storing animal records
        private string filePath = System.IO.Path.Combine(Application.StartupPath, "animals.txt");

        // Summary text path
        private string summaryPath = System.IO.Path.Combine(Application.StartupPath, "summary.txt");

        // FileHandler method
       
        

        // Load animal records from the file
        public List<Animal> LoadAnimals()
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

        // Add animal records to the file
        public void AppendAnimals(Animal animals)
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

        // Replace the matching animal line while preserving every other line as written.
        public void UpdateAnimal(string animalID, Animal updatedAnimal)
        {
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            int matchingLine = -1;

            for (int index = 0; index < lines.Length; index++)
            {
                string[] fields = lines[index].Split('|');
                if (fields.Length == 7 && string.Equals(fields[0].Trim(), animalID, StringComparison.OrdinalIgnoreCase))
                {
                    if (matchingLine >= 0)
                    {
                        throw new IOException("More than one record has this Animal ID. No changes were saved.");
                    }
                    matchingLine = index;
                }
            }

            if (matchingLine < 0)
            {
                throw new FileNotFoundException("The selected animal could not be found in animals.txt.");
            }

            lines[matchingLine] = updatedAnimal.FileFormat();
            string temporaryPath = filePath + ".tmp";
            try
            {
                File.WriteAllLines(temporaryPath, lines, new UTF8Encoding(false));
                File.Replace(temporaryPath, filePath, null);
            }
            finally
            {
                if (File.Exists(temporaryPath))
                {
                    File.Delete(temporaryPath);
                }
            }
        }

        // Deletes an animal from the files and keeps the remaining animals
        public void DeleteAnimal(string animalID)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string> leftoverAnimals = new List<string>();
            int anl = 0;

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (fields.Length == 7 && fields[0].Trim().Equals(animalID, StringComparison.OrdinalIgnoreCase))
                {
                    anl++;
                }
            else
            {
            leftoverAnimals.Add(line);
            }
        }

        if (anl == 0)
        {
            throw new FileNotFoundException("The animal selected could not be found, please try again");
        }

        if (anl > 1)
        {
            throw new IOException("Multiple animal ID's were found, could not delete");
        }

        string temporaryPath = filePath + ".tmp";

        try
        {
            File.WriteAllLines(temporaryPath, leftoverAnimals, new UTF8Encoding(false));
            File.Replace(temporaryPath, filePath, null);
        }
        finally
        {
            if (File.Exists (temporaryPath))
            {
            File.Delete(temporaryPath);
            }
        }    
    }

        // Formatted summary text to Summary.txt
        public void GenerateSummary()
        {
            List<Animal> animals = LoadAnimals();
            FileHandler handler = new FileHandler();

            int totalAniamls = animals.Count;

            double averageAge = 0;
            double averageScore = 0;

            if (totalAniamls > 0)
            {
                averageAge = animals.Average(a => a.Age);
                averageScore = animals.Average(a => a.RecoveryScore);
            }

            int critical = animals.Count(a => a.Status == "Critical");
            int serious = animals.Count(a => a.Status == "Serious");
            int Stable = animals.Count(a => a.Status == "Stable");
            int Recovering = animals.Count(a => a.Status == "Recovering");
            int releaseReady = animals.Count(a => a.Status == "Release-Ready");

            try
            {
                using (StreamWriter writer = new StreamWriter(summaryPath, false))
                {
                    writer.WriteLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                    writer.WriteLine("ANIMAL SUMMARY REPORT");
                    writer.WriteLine("Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                    writer.WriteLine("------------------------------------------");

                    if (totalAniamls == 0)
                    {
                        writer.WriteLine("Total animals: 0");
                        writer.WriteLine("Average age (years): N/A");
                        writer.WriteLine("Average recovery score: N/A");
                    }
                    else
                    {
                        writer.WriteLine($"{"Total animals:",-30}{totalAniamls}");
                        writer.WriteLine($"{"Average age (years):", -30}{averageAge:F2}");
                        writer.WriteLine($"{"Average recovery score:",-30}{averageScore:F2}");
                    }
                    writer.WriteLine("------------------------------------------");
                    writer.WriteLine("Animals per status:");
                    writer.WriteLine($"{"Critical:",-30}{critical}");
                    writer.WriteLine($"{"Serious:",-30}{serious}");
                    writer.WriteLine($"{"Stable:",-30}{Stable}");
                    writer.WriteLine($"{"Recovering:",-30}{Recovering}");
                    writer.WriteLine($"{"Release-Ready:",-30}{releaseReady}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to generate summary" + ex.Message);
            }
        }
    }
}
