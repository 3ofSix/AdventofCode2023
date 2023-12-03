namespace ThreeOfSix.Adventofcode;

public class CubeGame
{
    List<CubeGameSet> sets { get; }
    
    public CubeGame()
    {
        sets = new List<CubeGameSet>();
    }

    public void AddSet(CubeGameSet set)
    {
        sets.Add(set);
    }

}

public class CubeGameSet {
    public Dictionary<Cube, int> cubes  { get; }
    public CubeGameSet()
    {
        cubes = new Dictionary<Cube, int>();
    }

    public void AddCubeToSet(Cube cube, int numberOf)
    {
        cubes.TryAdd(cube, numberOf);
    }
}

public enum Cube
{
    Red,
    Green,
    Blue
}