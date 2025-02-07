namespace CRUD_Employee_management.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

        public DateTime DateHired { get; set; }

        public decimal Salary { get; set; }
    }
}
