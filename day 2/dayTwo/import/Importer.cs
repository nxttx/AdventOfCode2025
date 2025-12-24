using dayTwo.domain;

namespace dayTwo.import;

public class Importer
{
    public IEnumerable<IdRange> Import(string inputInputTxt = "input/input.txt")
    {
        string[] lines = File.ReadAllLines(inputInputTxt);
        var line = lines[0];
        lines = line.Split(',');
        return lines.Select(line => new IdRange(line));
    }
}