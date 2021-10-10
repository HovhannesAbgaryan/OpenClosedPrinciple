namespace OCPLibrary
{
    /// <summary>
    /// Employee model
    /// </summary>
    public class EmployeeModel
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
        /// Email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Is manager?
        /// </summary>
        public bool IsManager { get; set; } = false;

        /// <summary>
        /// Is executive?
        /// </summary>
        public bool IsExecutive { get; set; } = false;
    }
}
