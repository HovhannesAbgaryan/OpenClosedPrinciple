using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    /// <summary>
    /// Person accounts
    /// </summary>
    public class PersonAccounts : IAccounts
    {
        /// <summary>
        /// Create employee model from applicant model
        /// </summary>
        /// <param name="applicant">Applicant model</param>
        /// <returns>Employee model</returns>
        public EmployeeModel Create(IApplicantModel applicant)
        {
            var employeeModel = new EmployeeModel
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                EmailAddress = $"{ applicant.FirstName.Substring(0, 1) }{applicant.LastName}@acme.com"
            };

            return employeeModel;
        }
    }
}
