using System.Reflection;
using DayOne.domain;
using DayOne.import;

namespace DayOne;

class Program
{
    public static void Main()
    {
        var importer = new Importer();
        var moveRules = importer.Import();

        var prep = new List<int>();
        for(int i = 0; i < 100; i++) prep.Add(i);

        var round = new RoundEnumberable<int>(prep);
        while (round.Current != 50)
        {
            round.MoveNext();
        }
        
        var amountofZeroesAfterRotating = 0;
        var amountofZeroesDuringRotating = 0;
        
        foreach (var moveRule in moveRules)
        {
            for (int i = 0; i < moveRule.Steps; i++)
            {
                if (moveRule.TurnDirection == Direction.Left)
                {
                    round.MovePrevious();
                }
                else
                {
                    round.MoveNext();
                }
                if (round.Current == 0)
                {
                    amountofZeroesDuringRotating++;
                }
            }
            
            if (round.Current == 0)
            {
                amountofZeroesAfterRotating++;
            }
        }
        Console.WriteLine($"The first code is: {amountofZeroesAfterRotating}");
        Console.WriteLine($"The second code is: {amountofZeroesDuringRotating}");
    }
}

public class RoundEnumberable<T>
{
    public T Current
    {
        get => _list[_index];
    }
    private int _index;
    private List<T> _list;
    
    public RoundEnumberable(List<T> list)
    {
        _list = list;
        _index = 0;
    }
    
    public void MovePrevious()
    {
        if (_index == 0)
        {
            _index = _list.Count-1;
        }
        else
        {
            _index--;
        }
    }
    
    public void MoveNext()
    {
        if (_index == _list.Count -1)
        {
            _index = 0;
        }
        else
        {
            _index++;
        }
    }
}