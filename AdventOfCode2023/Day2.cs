using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<char>;

public class Day2 {

    public Day2() {
        Parser<char, string> parser1 = String("foo");
        Parser<char, string> parser2 = String("bar");
        Parser<char, string> sequencedParser = Map (
            (foo, bar) => bar + foo, parser2, parser1
        );
        // Parser<char, string> sequencedParser = parser1.Then(parser2);
        WriteLine(sequencedParser.ParseOrThrow("foobar"));
    }
}