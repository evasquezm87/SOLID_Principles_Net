using OCP_Library;

namespace OCP_Library
{
    public interface IApplicantModel
    {
        string firstName { get; set; }
        string lastName { get; set; }
        IAccount AccountProcessor { get; set; }
    }
}