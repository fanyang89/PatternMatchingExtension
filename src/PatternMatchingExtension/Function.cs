using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PatternMatchingExtension
{
    public class Function<TResult, TArg1>
    {
        private readonly List<Func<Function<TResult, TArg1>, TArg1, TResult>> _funcs = new List<Func<Function<TResult, TArg1>, TArg1, TResult>>();
        private readonly List<Func<TArg1, bool>> _predicates = new List<Func<TArg1, bool>>();

        public TResult Invoke(TArg1 arg1) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1)) {
                    return _funcs[i](this, arg1);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1> Match(Func<TArg1, bool> isMatch, Func<Function<TResult, TArg1>, TArg1, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2>, TArg1, TArg2, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2>, TArg1, TArg2, TResult>>();
        private readonly List<Func<TArg1, TArg2, bool>> _predicates = new List<Func<TArg1, TArg2, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2)) {
                    return _funcs[i](this, arg1, arg2);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2> Match(Func<TArg1, TArg2, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2>, TArg1, TArg2, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3>, TArg1, TArg2, TArg3, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3>, TArg1, TArg2, TArg3, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, bool>> _predicates = new List<Func<TArg1, TArg2, TArg3, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3)) {
                    return _funcs[i](this, arg1, arg2, arg3);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3> Match(Func<TArg1, TArg2, TArg3, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3>, TArg1, TArg2, TArg3, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3, TArg4>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4>, TArg1, TArg2, TArg3, TArg4, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4>, TArg1, TArg2, TArg3, TArg4, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, TArg4, bool>> _predicates = new List<Func<TArg1, TArg2, TArg3, TArg4, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3, arg4)) {
                    return _funcs[i](this, arg1, arg2, arg3, arg4);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3, TArg4> Match(Func<TArg1, TArg2, TArg3, TArg4, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3, TArg4>, TArg1, TArg2, TArg3, TArg4, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5>, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5>, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, bool>> _predicates = new List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3, arg4, arg5)) {
                    return _funcs[i](this, arg1, arg2, arg3, arg4, arg5);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5> Match(Func<TArg1, TArg2, TArg3, TArg4, TArg5, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5>, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, bool>> _predicates
            = new List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3, arg4, arg5, arg6)) {
                    return _funcs[i](this, arg1, arg2, arg3, arg4, arg5, arg6);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Match(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, bool>> _predicates
            = new List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3, arg4, arg5, arg6, arg7)) {
                    return _funcs[i](this, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Match(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, bool>> _predicates
            = new List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)) {
                    return _funcs[i](this, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Match(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> ToFunc() {
            return Invoke;
        }
    }

    public class Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
    {
        private readonly List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> _funcs
            = new List<Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>();
        private readonly List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, bool>> _predicates
            = new List<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, bool>>();

        public TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9) {
            Debug.Assert(_predicates.Count == _funcs.Count);
            for (var i = 0; i < _funcs.Count; i++) {
                if (_predicates[i](arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)) {
                    return _funcs[i](this, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                }
            }
            throw new NotSupportedException("Predicates doesn't contain all situations.");
        }

        public Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            Match(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, bool> isMatch,
            Func<Function<TResult, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> funcInvoke) {
            _predicates.Add(isMatch);
            _funcs.Add(funcInvoke);
            return this;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> ToFunc() {
            return Invoke;
        }
    }
}