public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Optional: Provide a getter for the student name for derived classes if private.
    public string GetStudentName()
    {
        return _studentName;
    }
}
