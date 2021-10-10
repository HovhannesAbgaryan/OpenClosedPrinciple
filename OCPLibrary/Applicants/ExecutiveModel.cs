using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    /// <summary>
    /// Executive model
    /// </summary>
    public class ExecutiveModel : IApplicantModel
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
        /// Account processor for executive
        /// </summary>
        public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
    }
}
