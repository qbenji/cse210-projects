using System.Runtime.CompilerServices;

public abstract class Goal
{
    private string _goalName;       // goal name
    private string _goalDesc;       // goal description
    private int _goalPoints;        // goal number
    private bool _isCompleted;      // is goal completed?
    
    public Goal(string goalName, string goalDesc, int goalPoints, bool isCompleted)   // constructor
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _isCompleted = isCompleted;
    }

    public virtual void        CreateGoal()            // create goal
    {
        Console.Clear();
        Console.Write("What is the name of your goal? > ");
        SetGoalName(Console.ReadLine());
        Console.Write("What is a short description of it? > ");
        SetGoalDesc(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? > ");
        SetGoalPoints(int.Parse(Console.ReadLine()));
    }

    public virtual string      RepresentGoal()         // represent goal as string
    {
        if (GetIsCompleted()==true)
        {
            return $"[X] {GetGoalName()} ({GetGoalDesc()})";
        }
        else
        {
            return $"[ ] {GetGoalName()} ({GetGoalDesc()})";
        }        
    }

    public abstract string      SerializeGoal();        // serialize goal as string

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

    public bool     GetIsCompleted()                    // get is goal completed?
    {
        return _isCompleted;
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

    public void     SetIsCompleted(bool isCompleted)    // set is goal completed?
    {
        _isCompleted = isCompleted;
    }

}