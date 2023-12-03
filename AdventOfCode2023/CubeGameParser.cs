using Pidgin;
using static Pidgin.Parser;

namespace ThreeOfSix.Adventofcode.Services;

public static class CubeGameParser 
{
    private static readonly Parser<char, char> _colon = Char(':');
    private static readonly Parser<char, char> _semiColon = Char(';');
    private static readonly Parser<char, char> _comma = Char(',');

}
