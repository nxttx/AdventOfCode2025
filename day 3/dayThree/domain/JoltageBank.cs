namespace dayThree.domain;

public class JoltageBank
{
    private string _original;
    public long[] Joltage { get; set; }

    public JoltageBank(string joltage)
    {
        _original = joltage;
        Joltage = new long[joltage.Length];
        for (int i = 0; i < joltage.Length; i++)
        {
            Joltage[i] = long.Parse(joltage[i].ToString());
        }
    }
    public int MaxJoltage()
    {
        var joltageWithoutLast = Joltage.Take(Joltage.Length-1).ToArray();
        var firstMaxLocation = Array.IndexOf(Joltage, joltageWithoutLast.Max());

        
        var temp = Joltage.ToList();
        temp.RemoveRange(0, firstMaxLocation+1);
        var secondMaxLocationUsingTemp = Array.IndexOf(temp.ToArray(), temp.Max());
        return int.Parse(Joltage[firstMaxLocation].ToString() + temp[secondMaxLocationUsingTemp].ToString());
    }

    public long MaxJoltage(int batterySize = 2)
    {
        var joltage = new long[Joltage.Length];
        Joltage.CopyTo(joltage);
        
        var workingJoltage = joltage.Take(joltage.Length - (batterySize-1));
        
        var max =  workingJoltage.Max();
        
        var joltageList = joltage.ToList();
            joltageList.RemoveRange(0, Array.IndexOf(joltage, max) + 1);
        var stringBank = new JoltageBank(string.Join("", joltageList));
        if (batterySize == 1)
        {
            return long.Parse(""+max);
        }

        return long.Parse(""+max + stringBank.MaxJoltage(batterySize - 1));
    }
}
