public class Goal
{
    private string _goalName;       // goal name
    private string _goalDesc;       // goal description
    private int _goalNum;           // goal number
    private string _goalType;       // goal type
    private int _goalPoints;        // points
    public Goal(string goalName, string goalDesc, int goalNum, string goalType, int goalPoints) // constructor
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalNum = goalNum;
        _goalType = goalType;
        _goalPoints = goalPoints;
    }

    public string GetGoalName()     // get goal name
    {
        return _goalName;
    }

    public string GetGoalDesc()     // get goal description
    {
        return _goalDesc;
    }

    public int GetGoalNum()         // get goal number
    {
        return _goalNum;
    }

    public string GetGoalType()     // get goal type
    {
        return _goalType;
    }

    public int GetGoalPoints()      // get goal points
    {
        return _goalPoints;
    }

    
}