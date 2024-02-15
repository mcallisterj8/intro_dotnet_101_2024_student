using System.Text.Json;
using FileIOJson.Models;

const string jsonFile = "./company_info.json";
string json = File.ReadAllText(jsonFile);

var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

// JSON.parse()
Company companyA = JsonSerializer.Deserialize<Company>(json, options);


// Prompt 3
const string dirName = "employees_directory";
Directory.CreateDirectory(dirName);

Directory.SetCurrentDirectory(dirName);

foreach(Employee person in companyA.Employees) {
    string contents = @$"
    ID: {person.Id}
    Full Name: {person.FullName}
    Annual Salary: {person.AnnualSalary}
    Position ID: {person.Position.Id}
    Position Description: {person.Position.Description}";

    File.WriteAllText($"{person.Id}.txt", contents);
}

// Move back to root of project
Directory.SetCurrentDirectory("..");