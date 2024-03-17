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

    public void     DisplayGoal()                   // display goal
    {
        Console.WriteLine($"{_goalNum}. {_goalName} ({_goalType}) - {_goalDesc} ({_goalPoints} points)");
    }

    public string   GetGoalName()                   // get goal name
    {
        return _goalName;
    }

    public string   GetGoalDesc()                   // get goal description
    {
        return _goalDesc;
    }

    public int      GetGoalNum()                    // get goal number
    {
        return _goalNum;
    }

    public string   GetGoalType()                   // get goal type
    {
        return _goalType;
    }

    public int      GetGoalPoints()                 // get goal points
    {
        return _goalPoints;
    }

    public void     SetGoalName(string goalName)    // set goal name
    {
        _goalName = goalName;
    }

    public void     SetGoalDesc(string goalDesc)    // set goal description
    {
        _goalDesc = goalDesc;
    }

    public void     SetGoalNum(int goalNum)         // set goal number
    {
        _goalNum = goalNum;
    }

    public void     SetGoalType(string goalType)    // set goal type
    {
        _goalType = goalType;
    }

    public void     SetGoalPoints(int goalPoints)   // set goal points
    {
        _goalPoints = goalPoints;
    }


}