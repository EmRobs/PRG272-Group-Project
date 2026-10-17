using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rehabilitation_Records_System
{
    public static class ExceptionHandler
    {
        public static void ValidateInput(string id, string name, string species, string age, string score, bool checkIdUniqueness = true)
        {
            // FileHandler object
            FileHandler handler = new FileHandler();

            //ID Validation
            string cleanID = id.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(cleanID) || !Regex.IsMatch(cleanID, @"^WR-\d{4}$")) 
            {
                throw new ArgumentException("Animal ID must be in the format 'WR-XXXX' where XXXX are digits.", nameof(id));
            }

            //Name Validation
            string cleanName = name.Trim();
            if (string.IsNullOrWhiteSpace(cleanName) || cleanName.Length > 30 || cleanName.Contains("|"))
            {
                throw new ArgumentException("Animal name is required, must be 30 characters or fewer, and cannot contain |.", nameof(name));
            }

            //Species Validation
            string cleanSpecies = species.Trim();
            if (string.IsNullOrWhiteSpace(cleanSpecies) || cleanSpecies.Length > 30 || cleanSpecies.Contains("|"))
            {
                throw new ArgumentException("Animal species is required, must be 30 characters or fewer, and cannot contain |.", nameof(species));
            }

            //Age Validation
            if (!int.TryParse(age, out int parsedAge) || parsedAge < 0 || parsedAge > 100)
            {
                throw new ArgumentException("Animal age must be a whole number between 0 and 100.", nameof(age));
            }

            //Recovery Score Validation
            if (!int.TryParse(score, out int parsedScore) || parsedScore < 0 || parsedScore > 100)
            {
                throw new ArgumentException("Recovery score must be a whole number between 0 and 100.", nameof(score));
            }

            //Enure ID is unique
            if (checkIdUniqueness)
            {
                List<Animal> animals = handler.LoadAnimals();
                foreach (var animal in animals)
                {
                    if (string.Equals(animal.AnimalID, cleanID, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException("Animal ID must be unique. An animal with this ID already exists.", nameof(id));
                    }
                }
            }
        }
    }
}
