namespace dayTwo.domain;

public class IdRange
{
    private string _original; 
    public IdRange(string original)
    {
        _original = original;
        var split = original.Split('-');
        
        var a = long.Parse(split[0]);
        var b = long.Parse(split[1]);
        
        UpperBound = a > b ? a : b;
        LowerBound = a < b ? a : b;
    }

    public long UpperBound { get; }
    public long LowerBound{ get; }

    public List<long> Range {
        get
        {
            var item = new List<long>();
            item.Add(LowerBound);

            while (item.Last() != UpperBound)
            {
                item.Add(item.Last() + 1);
            }
            return item;
        }
    }
}