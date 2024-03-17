using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{

    private int _countToBonus;    // count to bonus
    private int _bonusPoints;     // bonus points

    public ChecklistGoal(string goalName, string goalDesc, int goalNum, string goalType, int goalPoints, int bonusPoints, int countToBonus)    // constructor
        : base(goalName, goalDesc, goalNum, goalType, goalPoints) 
    {
        _countToBonus = countToBonus;
        _bonusPoints = bonusPoints;
    }



    public int GetCountToBonus()   // get count to bonus
    {
        return _countToBonus
    }

    public int GetBonusPoints()    // get bonus points
    {
        return _bonusPoints;
    }

    public void SetCountToBonus(int countToBonus)    // set count to bonus
    {
        _countToBonus = countToBonus;
    }

    public void SetBonusPoints(int bonusPoints)     // set bonus points
    {
        _bonusPoints = bonusPoints;
    }

}