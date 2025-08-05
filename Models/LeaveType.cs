namespace LeaveManagementSystem.Models;

public class LeaveType
{
    public int Id { get; set; }
    public string Name { get; set; }  // Sick, Casual, Annual
    public int DefaultDays { get; set; }
}