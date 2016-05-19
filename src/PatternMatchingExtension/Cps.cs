using System;
using System.Collections.Generic;

namespace PatternMatchingExtension
{
    public static class Cps
    {
        public static void Println(this object target) {
            target.Invoke(Console.WriteLine);
        }

        public static void Invoke(this object target, Action<object> action) {
            action(target);
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
            foreach (var value in enumerable) {
                action(value);
            }
        }
    }
}