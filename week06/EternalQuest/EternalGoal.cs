public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No extra line needed here.
    }
    public override void RecordEvent()
    {
        // Eternal goals are endless, so no action is needed here.
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are endless.
    }  
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal|{_shortName}|{_description}|{_points}";
    }
}