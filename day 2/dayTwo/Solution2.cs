using dayTwo.import;

namespace dayTwo;

class Solution2
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
                countOfAllIds += ExtractRepeatedSubstringPatterns(item);
            }
        }
        Console.WriteLine(countOfAllIds);
    }

    private static long ExtractRepeatedSubstringPatterns(long item)
    {
        var str = item.ToString();
        for (int i = 1; i <= str.Length / 2; i++)
        {
            List<string> partials = new();
            for (int j = 0; j <  str.Length/i; j++)
            {
                partials.Add(str.Substring(j*i, i));
            }

            var charCheck = partials.Count() * i;
            if (charCheck != str.Length) continue;
                    
                    
            var distinct = partials.Distinct();
            if (distinct.Count() != 1) continue;
            return item;
        }

        return 0;
    }
}