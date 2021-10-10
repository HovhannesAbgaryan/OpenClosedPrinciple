using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    /// <summary>
    /// Accounts
    /// </summary>
    public interface IAccounts
    {
        /// <summary>
        /// Create employee model from applicant model
        /// </summary>
        /// <param name="applicant">Applicant model</param>
        /// <returns>Employee model</returns>
        EmployeeModel Create(IApplicantModel applicant);
    }
}