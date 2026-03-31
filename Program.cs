using FunNamer;

string name = string.Empty;
do
{
    var adj = Adj.Random();
    var n = Names.Random();
    name = $"{adj}_{n}";
} while (name == "boring_wozniak");
// As noted in the <a href="https://github.com/moby/moby/blob/master/internal/namesgenerator/names-generator.go#L852">original</a>,
// Steve Wozniak is not boring
Console.WriteLine(name);