namespace ThreeOfSix.Adventofcode;

public static class Puzzle
{
    public static void ReadByLine(string path, Action<string> action)
    {
        string? line;
        try
        {
            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine();

            while (line != null)
            {
                action(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Read all of file..");
        }
    }
}