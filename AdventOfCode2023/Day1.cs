/*
 Read line by line
 use regex to get 1st and last digit
 regex for digit \d
 Regex groups first and last
 multiply fisrt match by 10 + second match
*/

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ThreeOfSix.Adventofcode;

public class Day1
{
    Action<string>? PuzzlePart;
    string patternPart1 = @"(\d)";
    string patternPart2 = @"(?=(one|two|three|four|five|six|seven|eight|nine|\d))";
    Regex regexPart1;
    Regex regexPart2;

    int sumPart1 = 0;
    int sumPart2 = 0;
    string filePath = "Files/Day1.txt";
    public Day1()
    {
        regexPart1 = new Regex(patternPart1, RegexOptions.IgnoreCase);
        regexPart2 = new Regex(patternPart2, RegexOptions.IgnoreCase);
    }

    private void Part1(string line)
    {

        MatchCollection matches = regexPart1.Matches(line);

        Match first = matches.First();
        Match last = matches.Last();
        sumPart1 = sumPart1 + Int32.Parse(first.Value + last.Value);
    }

    private void Part2(string line)
    {

        //Part 2 answer 57325 is too low!
        // 59769 is too high!
        // Answer is 57345
        MatchCollection matches2 = regexPart2.Matches(line);

        Group f = matches2.First().Groups[1];
        Group l = matches2.Last().Groups[1];
        sumPart2 = sumPart2 + Int32.Parse(ParseText(f.Value) + ParseText(l.Value));
    }

    public void Solve()
    {
        PuzzlePart = Part1;
        Puzzle.ReadByLine(filePath, PuzzlePart);
        PuzzlePart = Part2;
        Puzzle.ReadByLine(filePath, PuzzlePart);
        WriteLine("Part1 sum: {0}", sumPart1);
        WriteLine("Part2 sum: {0}", sumPart2);
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
}