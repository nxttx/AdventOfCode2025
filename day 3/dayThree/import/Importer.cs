using dayThree.domain;

namespace dayThree.import;

public class Importer
{
    public IEnumerable<JoltageBank> Import(string inputInputTxt = "input/input.txt")
    {
        string[] lines = File.ReadAllLines(inputInputTxt);
        return lines.Select(line => new JoltageBank(line));
    }
}