using System;
using System.Collections.Generic;

namespace PatternMatchingExtension.Test
{
    static class Program
    {
        static void Main(string[] args) {
            "MatchExpression Test".Println();

            "foo"
                .Match<int>(x => Console.WriteLine($"int {x}"))
                .Match<string>(x => Console.WriteLine($"string {x}"))
                .Match<_>(x => Console.WriteLine($"object {x}"))
                ;

            new { a = 1, b = 2 }
                .Match<string, int>((x1, x2) => Console.WriteLine($"<string, int> {x1} {x2}"))
                .Match<int, int>((x1, x2) => Console.WriteLine($"<int, int> {x1} {x2}"))
                ;

            var len = new Function<int, IList<int>>()
                .Match(list => list.IsEmpty(), (ctx, list) => 0)
                .Match(list => true, (ctx, list) => list.Match((x, xs) => ctx.Invoke(xs) + 1))
                .ToFunc()
                ;
            len(new List<int> { 1, 2, 3, 4, 5 }).Println();
            
            var fib = new Function<int, int>()
                  .Match(x => x == 0, (ctx, x) => 0)
                  .Match(x => x == 1, (ctx, x) => 1)
                  .Match(x => x > 1, (ctx, x) => ctx.Invoke(x - 1) + ctx.Invoke(x - 2))
                  .Match(x => true, (ctx, x) => { throw new ArgumentOutOfRangeException(nameof(x)); })
                  .ToFunc()
                  ;
            $"fib(10) = {fib(10)}".Println();

            Console.ReadKey();
        }
    }
}
