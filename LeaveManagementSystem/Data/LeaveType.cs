namespace LeaveManagementSystem.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
