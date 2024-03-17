using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{

    private int _countToBonus;    // count to bonus
    private int _bonusPoints;     // bonus points
    private int _currentCount;    // current count

    public ChecklistGoal(string goalName, string goalDesc, int goalPoints, bool isCompleted, int bonusPoints, int countToBonus, int currentCount)    // constructor
        : base(goalName, goalDesc, goalPoints, isCompleted) 
    {
        _countToBonus = countToBonus;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override void CreateGoal()   // create goal
    {
        Console.Clear();
        Console.Write("What is the name of your goal? > ");
        SetGoalName(Console.ReadLine());
        Console.Write("What is a short description of it? > ");
        SetGoalDesc(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? > ");
        SetGoalPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times does this goal need to be accomplished for a bonus? > ");
        SetCountToBonus(int.Parse(Console.ReadLine()));
        Console.Write("What is the bonus for accomplishing it that many times? > ");
        SetBonusPoints(int.Parse(Console.ReadLine()));
    }

    public override string   RepresentGoal()     // represent goal as string
    {
        if (GetIsCompleted()==true)
        {
            return $"[X] {GetGoalName()} ({GetGoalDesc()}) -- Currently Completed: {GetCurrentCount()}/{GetCountToBonus()}";
        }
        else
        {
            return $"[ ] {GetGoalName()} ({GetGoalDesc()}) -- Currently Completed: {GetCurrentCount()}/{GetCountToBonus()}";
        }
    }   

    public override string   SerializeGoal()     // serialize goal as string
    {
        return $"ChecklistGoal:{GetGoalName()},{GetGoalDesc()},{GetGoalPoints()},{GetBonusPoints()},{GetCountToBonus()},{GetCurrentCount()}";
    } 

    public int GetCountToBonus()   // get count to bonus
    {
        return _countToBonus;
    }

    public int GetBonusPoints()    // get bonus points
    {
        return _bonusPoints;
    }

    public int GetCurrentCount()   // get current count
    {
        return _currentCount;
    }

    public void SetCountToBonus(int countToBonus)   // set count to bonus
    {
        _countToBonus = countToBonus;
    }

    public void SetBonusPoints(int bonusPoints)     // set bonus points
    {
        _bonusPoints = bonusPoints;
    }

    public void SetCurrentCount(int currentCount)   // set current count
    {
        _currentCount = currentCount;
    }
}