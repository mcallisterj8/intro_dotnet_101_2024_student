using FileIOJson.Models;

public class EmployeeWriter {
    public string WritePath { get; set; }

    public EmployeeWriter(string writePath) {
        this.WritePath = writePath;
    }

    public void Write(Employee emp, EmployeeOptions? options = null) {        
        Directory.CreateDirectory(this.WritePath);
        
        Directory.SetCurrentDirectory(this.WritePath);

        string fileName = $"{emp.Id}.txt";
        string contents = @$"
        ID: {emp.Id}
        Full Name: {emp.FullName}
        Annual Salary: {emp.AnnualSalary}";

        if(null == options) {
            options = new EmployeeOptions();
        }

        if(options.IncludePosition) {
            contents += @$"
            Position
            ----------
            Position ID: {emp.Position.Id}
            Position Description: {emp.Position.Description}
            ";
        }

        if(options.IncludeBenefits) {
            contents += @"
            Benefits
            ----------
            ";
            foreach(Benefit benefit in emp.Benefits) {
                contents += $@"
                ID: {benefit.Id}
                Description: {benefit.Description}
                Additional Amount: {benefit.Additional}
                ---------------------------------
                                ";
            }
        }

        File.WriteAllText(fileName, contents);
        Directory.SetCurrentDirectory("..");
    }

    public void WriteAll(List<Employee> employees, EmployeeOptions? options) {
        foreach(Employee emp in employees) {
            this.Write(emp, options);
        }
    }

}
