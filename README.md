# PatternMatchingExtension

Pattern matching extension methods for C#6

# Example

```CSharp
            "foo"
                .Match<int>(x => Console.WriteLine($"int {x}"))
                .Match<string>(x => Console.WriteLine($"string {x}"))
                .Match<_>(x => Console.WriteLine($"object {x}"))
                ;

            new { a = 1, b = 2 }
                .Match<string, int>((x1, x2) => Console.WriteLine($"<string, int> {x1} {x2}"))
                .Match<int, int>((x1, x2) => Console.WriteLine($"<int, int> {x1} {x2}"))
                ;

            var len = new Function<IList<int>, int>()
                .Match(list => list.IsEmpty(), self => list => 0)
                .Match(list => true, self => list => list.Match((x, xs) => self.Invoke(xs) + 1))
                .ToFunc()
                ;
            len(new List<int> { 1, 2, 3, 4, 5 }).Println();

            var fib = new Function<int, int>()
                  .Match(x => x == 0, self => x => 0)
                  .Match(x => x == 1, self => x => 1)
                  .Match(x => x > 1, self => x => self.Invoke(x - 1) + self.Invoke(x - 2))
                  .Match(_ => true, self => _ => { throw new ArgumentOutOfRangeException(nameof(_)); })
                  .ToFunc()
                  ;
            $"fib(10) = {fib(10)}".Println();
```
