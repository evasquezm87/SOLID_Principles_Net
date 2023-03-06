
// See https://aka.ms/new-console-template for more information
/*OCP Open for extension, Close for modification
 In a new extension dont affect the productive code*/
using OCP_Library;
using OCP_Library.Applicants;

Console.WriteLine("Welcome!");

List<IApplicantModel> applicant = new List<IApplicantModel>
{
    new PersonModel {firstName = "Luis", lastName = "Vasquez"},
    new ManagerModel  {firstName = "Juan", lastName = "Perez"},
    new ExecutiveModel  {firstName = "Jonh", lastName = "Smith"}
};

List<EmployeeModel> employees = new List<EmployeeModel>();
//Account accountProcessor = new Account();


foreach(var person in applicant)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach(var employee in employees)
{
    Console.WriteLine($"{employee.firstName} {employee.lastName} : {employee.emailAdress} IsManager: { employee.isManager } IsExecutive {employee.isExecutive} ");
}

Console.ReadLine(); 
