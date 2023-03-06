using OCP_Library.Applicants;

namespace OCP_Library
{
    public interface IAccount
    {
        EmployeeModel Create(IApplicantModel person);
    }
}