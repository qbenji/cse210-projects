public class SimpleGoal :Goal
{
    public SimpleGoal(string goalName, string goalDesc, int goalPoints, bool isCompleted)    // constructor
        : base(goalName, goalDesc, goalPoints, isCompleted) 
    {}

    public override string SerializeGoal()      // serialize goal as string
    {
        return $"SimpleGoal:{GetGoalName()},{GetGoalDesc()},{GetGoalPoints()},{GetIsCompleted()}";
    }
    
}