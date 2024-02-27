using System.Text.Json;
using FileIOJson.Models;

const string jsonFile = "./company_info.json";
string json = File.ReadAllText(jsonFile);

var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

// JSON.parse()
Company companyA = JsonSerializer.Deserialize<Company>(json, options);

const string employeeDir = "employees";
EmployeeWriter writer = new EmployeeWriter(employeeDir);

EmployeeOptions empOptions = new EmployeeOptions() { IncludePosition = true, IncludeBenefits = true };

writer.WriteAll(companyA.Employees, empOptions);

