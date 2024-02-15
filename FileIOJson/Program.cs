using System.Text.Json;
using FileIOJson.Models;

const string jsonFile = "./company_info.json";
string json = File.ReadAllText(jsonFile);

var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

// JSON.parse()
Company companyA = JsonSerializer.Deserialize<Company>(json, options);


/**********************************************
 *************** PROMPT 3 BEGIN ***************
***********************************************/
// const string dirName = "employees_directory";
// Directory.CreateDirectory(dirName);

// Directory.SetCurrentDirectory(dirName);

// foreach(Employee person in companyA.Employees) {
//     string contents = @$"
//     ID: {person.Id}
//     Full Name: {person.FullName}
//     Annual Salary: {person.AnnualSalary}
//     Position ID: {person.Position.Id}
//     Position Description: {person.Position.Description}
    
//     Benefits
//     ----------
//     ";

//     foreach(Benefit benefit in person.Benefits){
//         contents += @$"
//         {benefit.Description}";
//     }

//     File.WriteAllText($"{person.Id}.txt", contents);
// }

// // Move back to root of project
// Directory.SetCurrentDirectory("..");

/**********************************************
 *************** PROMPT 3 END ***************
***********************************************/


/**********************************************
 *************** PROMPT 9 BEGIN ***************
***********************************************/

Employee personA = companyA.Employees[0];
Console.WriteLine($"{personA.FullName} position BEFORE: {personA.Position.Description}");

personA.Position.Description = "Architect";

Console.WriteLine($"{personA.FullName} position AFTER: {personA.Position.Description}");

var moreOptions = new JsonSerializerOptions() {WriteIndented = true};

string jsonString = JsonSerializer.Serialize(companyA, moreOptions);

File.WriteAllText(jsonFile, jsonString);

/**********************************************
 *************** PROMPT 9 END ***************
***********************************************/