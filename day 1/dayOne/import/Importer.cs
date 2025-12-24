using DayOne.domain;

namespace DayOne.import;

public class Importer
{
    public IEnumerable<MoveRule> Import()
    {
        // read file from ../input/input.txt
        string[] lines = System.IO.File.ReadAllLines("input/input.txt");
        return lines.Select(line => new MoveRule(line));
    }
}