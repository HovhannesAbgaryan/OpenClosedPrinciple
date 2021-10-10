using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    /// <summary>
    /// Person model
    /// </summary>
    public class PersonModel : IApplicantModel
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
        /// Account processor for person
        /// </summary>
        public IAccounts AccountProcessor { get; set; } = new PersonAccounts();
    }
}
