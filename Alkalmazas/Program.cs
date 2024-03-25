using ClassLibrary.Data;
using ClassLibrary.Models;

var _context = new Context();

if (!_context.Emberek.Any())
{
    var sorok = File.ReadAllLines(@"c:\Data\dolgozat\5.csv").Skip(1);
    foreach (var a in sorok)
    {
        _context.Emberek.Add(new Emberek(a));
    }
    _context.SaveChanges();
}

foreach (var item in _context.Emberek)
{
    Console.WriteLine(item);
}