// W05 Learning Activity - Inheritance
// Base Assignment class
// Stores common information for all assignments.

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor to initialize assignment details
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns a summary containing the student's name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Returns the student name for derived classes
    public string GetStudentName()
    {
        return _studentName;
    }
}