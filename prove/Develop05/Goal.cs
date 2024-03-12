public class Goal
{
    private string _goalName;       // goal name
    private string _goalDesc;       // goal description
    private int _goalNum;           // goal number
    private string _goalType;       // goal type
    private int _points;            // points
    public Goal(string goalName, string goalDesc, int goalNum, string goalType, int points) // constructor
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalNum = goalNum;
        _goalType = goalType;
        _points = points;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    
}