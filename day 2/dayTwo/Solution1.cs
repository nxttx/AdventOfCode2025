using dayTwo.import;

namespace dayTwo;

class Solution1
{
    public static void Run()
    {
        var importer = new Importer();
        var idRanges = importer.Import();


        long countOfAllIds = 0;
        foreach (var idRange in idRanges)
        {
            var range = idRange.Range;
            foreach (var item in range)
            {
                var str = item.ToString();
                if (str.Length.IsEven())
                {
                    var firstHalve= str.Substring(0, str.Length / 2);
                    var secondHalve = str.Substring(str.Length / 2);
                    if (firstHalve == secondHalve)
                    {
                        countOfAllIds += item;
                    }
                }
            }
        }
        Console.WriteLine(countOfAllIds);
    }
}