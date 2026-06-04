// W05 Learning Activity - Inheritance

public class Assignment
{
    private string _studentName;
    private string _topic;

    // This is for Constructor to initialize assignment details
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