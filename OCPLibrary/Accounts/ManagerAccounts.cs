using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    /// <summary>
    /// Manager accounts
    /// </summary>
    public class ManagerAccounts : IAccounts
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
                EmailAddress = $"{ applicant.FirstName.Substring(0, 1) }{applicant.LastName}@acmecorp.com",

                IsManager = true
            };

            return employeeModel;
        }
    }
}
