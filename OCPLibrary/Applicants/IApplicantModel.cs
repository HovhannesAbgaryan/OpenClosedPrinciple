using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    /// <summary>
    /// Applicant model
    /// </summary>
    public interface IApplicantModel
    {
        /// <summary>
        /// First name
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Account processor
        /// </summary>
        IAccounts AccountProcessor { get; set; }
    }
}