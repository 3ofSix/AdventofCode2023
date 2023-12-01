/*
 Read line by line
 use regex to get 1st and last digit
 regex for digit \d
 Regex groups first and last
 multiply fisrt match by 10 + second match
*/

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Day1
{

    String? line;
    string pattern = @"(\d)";
    string pattern2 = @"(?=(one|two|three|four|five|six|seven|eight|nine|\d))";
    // string pattern2 = @"(one|two|three|four|five|six|seven|eight|nine|\d)";
    Regex regex;
    Regex regex2;
    public Day1()
    {
        regex = new Regex(pattern, RegexOptions.IgnoreCase);
        regex2 = new Regex(pattern2, RegexOptions.IgnoreCase);
    }

    public void Solve()
    {


        try
        {
            // StreamReader sr = new StreamReader("Files\\Day1Sample2.txt");
            StreamReader sr = new StreamReader("Files/Day1.txt");
            int sum = 0;
            int sum2 = 0;
            line = sr.ReadLine();

            while (line != null)
            {
                // Part 1

                // MatchCollection matches = regex.Matches(line);
                // Match first = matches.First();
                // Match last = matches.Last();
                // // Console.WriteLine("{0}{1}", first.Value, last.Value);
                // // sum = sum + Int32.Parse(first.Value + last.Value);
                // sum = sum + Int32.Parse(ParseText(first.Value) + ParseText(last.Value));

                //Part 2 answer 57325 is too low!
                // 59769 is too high!
                // Anser is 57345
                MatchCollection matches2 = regex2.Matches(line);
                
                Group f = matches2.First().Groups[1];
                Group l = matches2.Last().Groups[1];
                sum2 = sum2 + Int32.Parse(ParseText(f.Value) + ParseText(l.Value));
                Console.WriteLine("{0}: {1} {2}: {3}{4}: sum {5}", line, f.Value, l.Value, ParseText(f.Value), ParseText(l.Value), sum2);

                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.WriteLine("Final sum {0}", sum);
            Console.WriteLine("Final sum2 {0}", sum2);
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }

    private string ParseText(string text)
    {
        string value = text;
        switch (text.ToLower())
        {
            case "one":
                value = "1";
                break;
            case "two":
                value = "2";
                break;
            case "three":
                value = "3";
                break;
            case "four":
                value = "4";
                break;
            case "five":
                value = "5";
                break;
            case "six":
                value = "6";
                break;
            case "seven":
                value = "7";
                break;
            case "eight":
                value = "8";
                break;
            case "nine":
                value = "9";
                break;
            default:
                break;
        }

        return value;
    }

    public void example() {
        string pattern = @"(?=(one|two|three|four|five|six|seven|eight|nine|\d))";
        string input = @"ctwoneqcmffptjzpone3brdtb4bjnzqx
eight4tjfvrvlcfgdtk61fouroneightjvf
43eightnvdrthree1eightoneggrdmnp
eight4tjfvrvlcfgdtk61fouroneightjv3f";
        RegexOptions options = RegexOptions.Multiline;
        
        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("Match: '{0}' found at index {1}. Value:{2}.\nGroup", m.Value, m.Index, m.Groups[1].Value);
            foreach (Group group in m.Groups)
            {
                Console.WriteLine("\t{0} value at index {1}.", group.Value, group.Index);
            }
        }
    }
}