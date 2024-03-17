public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDesc, int goalPoints, bool isCompleted)    // constructor
        : base(goalName, goalDesc, goalPoints, isCompleted) 
    {}

    public override string SerializeGoal()      // serialize goal as string
    {
        return $"EternalGoal:{GetGoalName()},{GetGoalDesc()},{GetGoalPoints()}";
    }
    
}