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


}