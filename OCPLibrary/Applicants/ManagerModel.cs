using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    /// <summary>
    /// Manager model
    /// </summary>
    public class ManagerModel : IApplicantModel
    {
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Account processor for manager
        /// </summary>
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
