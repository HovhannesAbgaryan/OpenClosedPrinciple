using OCPLibrary;
using OCPLibrary.Applicants;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        /// <summary>
        /// Welcome message
        /// </summary>
        static void WelcomeMessage()
        {
            Console.WriteLine("SOLID Principles");
            Console.WriteLine("The O in SOLID - Open-closed Principle (OCP)");
            Console.WriteLine("Welcome to OCPDemo application!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Display welcome message
            WelcomeMessage();

            //Create new list of applicants
            var applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new ExecutiveModel { FirstName = "Tony", LastName = "Stark" }
            };

            //Create new list of employees
            var employees = new List<EmployeeModel>();

            //For each applicant in the list of applicants
            foreach (var applicant in applicants)
                //create an employee from applicant and add that employee to the list of employees
                employees.Add(applicant.AccountProcessor.Create(applicant));

            //For each employee in the list of employees
            foreach (var employee in employees)
                //print information about the employee
                Console.WriteLine($"{ employee.FirstName } { employee.LastName }: { employee.EmailAddress } IsManager: { employee.IsManager } IsExecutive: { employee.IsExecutive }");
        }
    }
}
