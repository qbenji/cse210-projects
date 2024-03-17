public class Goal
{
    private string _goalName;       // goal name
    private string _goalDesc;       // goal description
    private int _goalPoints;        // goal number

    public Goal(string goalName, string goalDesc, int goalPoints)   // constructor
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
    }

    public virtual string CreateGoal()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? > ");
        SetGoalName(Console.ReadLine());
        Console.Write("What is a short description of it? > ");
        SetGoalDesc(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? > ");
        SetGoalPoints(int.Parse(Console.ReadLine()));
        return "";
    }

    public string   GetGoalName()                       // get goal name
    {
        return _goalName;
    }

    public string   GetGoalDesc()                       // get goal description
    {
        return _goalDesc;
    }

    public int      GetGoalPoints()                     // get goal number
    {
        return _goalPoints;
    }

    public void     SetGoalName(string goalName)        // set goal name
    {
        _goalName = goalName;
    }

    public void     SetGoalDesc(string goalDesc)        // set goal description
    {
        _goalDesc = goalDesc;
    }

    public void     SetGoalPoints(int goalPoints)       // set goal number
    {
        _goalPoints = goalPoints;
    }

}