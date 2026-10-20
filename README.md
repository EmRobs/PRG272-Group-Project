# Baobab Ridge Wildlife Rehabilitation Records System 
## Group Members:
| Name | Student Number |
|------|----------------|
| Emily Roberts | 604735 |
| Cormac Range | 604054 |
| Lohan Pelser | 603888 |
| Wian Joubert | 604535 |
| Tristan Bezuidenhout | 604842 | 

## Project Description 
The Baobab Ridge Wildlife Rehabilitation Records System is a C# Windows Form application developed for the fictional Baobab Ridge Wildlife Centre. The system stores animal records in text files, automatically classifies each animal based on its recovery score, and allows users to manage rehabilitation records. 

## How to run and build the program
1. Clone or download the GitHub repository. 
2. Open the solution (`.sln`) in Visual Studio. 
3. Build the solution (**Ctrl + Shift + B**)
4. Run the application (**F5** or click start)


## Features 
- Add a new animal 
- View all animals
- Update an existing animal
- Delete an animal
- Generate summary report
- Automatic status and housing unit classifications
- Input validation and error handling

## File Formats
### animals.txt 
Stores all animal records. 

Each line contains one animal record using the following format:
```
AnimalID | Name | Species | Age | RecoveryScore | Status | HousingUnit
```

Example:
```
WR-0001 | Thabo | African Penguin | 4 | 85 | Release-Ready | Pre-Release Camp
```

### summary.txt
Generated whenever the **Generate Summary** feature is used.

The file contains:
- Total number of animals
- Average animal age 
- Average recovery age
- Number of animals in each status
- Date and time the report was generated

Each time the summary is generated, the existing `summary.txt` file is overwritten.

## Known Limitations
- Data is stored in plain text files instead of a database
- The application is intended for a single user at a time
- The application must be run from Visual Studio or the compiled executable folder so the text files can be located correctly.
