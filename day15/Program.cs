var lines = File.ReadAllLines("sample.txt").Where(l => !string.IsNullOrEmpty(l)).ToArray();
Map myMap = new Map();

for (int x = 0; x < lines.Length; x++)
{
    for (int y = 0; y < lines[x].Length; y++)
    {
        int value = int.Parse(lines[x][y].ToString());
        myMap.Coordinates.Add(new Coordinate(x, y, value));
    }
}
Console.WriteLine($"Added map with {myMap.Coordinates.Count} coordinates.");
Console.WriteLine($"Map has {myMap.Rows} rows.");
Console.WriteLine($"Map has {myMap.Cols} cols.");

var qInvestigate = new PriorityQueue<(int, int), int>();

public class Map
{
    public List<Coordinate> Coordinates = new();
    public int CoordinateCount => Coordinates.Count;
    public int Rows => Coordinates.MaxBy(c => c.X).X + 1;
    public int Cols => Coordinates.MaxBy(c => c.Y).Y + 1;
}

public class Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool Visited { get; set; }
    public int Value { get; set; }

    public Coordinate(int iX, int iY, int iValue)
    {
        X = iX;
        Y = iY;
        Value = iValue;
    }
}