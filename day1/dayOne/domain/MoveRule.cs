namespace DayOne.domain;

public class MoveRule
{
    public Direction TurnDirection { get; set; }
    public int Steps { get; set; }

    public MoveRule(Direction turnDirection, int steps)
    {
        TurnDirection = turnDirection;
        Steps = steps;
    }
    
    public MoveRule(string rule)
    {
        if (rule.Length < 2) throw new ArgumentException("Move rule must be 2 characters long");
        if (rule[0] != 'L' && rule[0] != 'R') throw new ArgumentException("Move rule must start with L or R");

        TurnDirection = rule[0] == 'L' ? Direction.Left : Direction.Right;
        Steps = int.Parse(rule.Substring(1));
    }
}

public enum Direction { Left, Right }