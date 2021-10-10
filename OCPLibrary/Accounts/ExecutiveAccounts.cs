using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    /// <summary>
    /// Executive accounts
    /// </summary>
    public class ExecutiveAccounts : IAccounts
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
                EmailAddress = $"{ applicant.FirstName }.{applicant.LastName}@acmecorp.com",

                IsManager = true,
                IsExecutive = true
            };

            return employeeModel;
        }
    }
}
