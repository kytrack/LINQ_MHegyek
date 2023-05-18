using Hegyescsucsos;
List<Hegycsucsosztaly> csucsok = new List<Hegycsucsosztaly>();

StreamReader sr = new StreamReader("hegyekMo.txt");
sr.ReadLine();

while (!sr.EndOfStream)
{
    string[] hegyek = sr.ReadLine().Split(";");
    csucsok.Add(new Hegycsucsosztaly(hegyek[0], hegyek[1],int.Parse(hegyek[2])));
}
sr.Close();

Console.WriteLine($"3.feladat: Hegycsúcsok száma: {csucsok.Count()} db");

Console.WriteLine($"4.feladat: Hegycsúcsok átlagos magassága {csucsok.Average(x => x.Magassag)}");

var legmagasabbAdatok = csucsok.OrderByDescending(csucs => csucs.Magassag).First();
Console.WriteLine($"5.feladat: A legmagasabb hegycsúcs adatai:\n\tNév: {legmagasabbAdatok.Nev}\n\tHegység: {legmagasabbAdatok.Hegyseg}\n\tMagasság: {legmagasabbAdatok.Magassag}m");

Console.WriteLine("6.feladat: Kérek egy magasságot: ");
int bekertMgassag=int.Parse(Console.ReadLine());
