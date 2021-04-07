using System;
using System.Collections.Generic;
using Bootcamp.SOLID.SRP.Correct.CalculationRules;

namespace Bootcamp.SOLID.SRP.Correct
{
    public struct Office
    {
        public int Code { get; }

        public const int Developer = 1;
        public const int Manager = 2;
        public const int Tester = 3;

        private static readonly Dictionary<int, ICalculationRule> Rules = new()
        {
            {Developer, new ReduceTenPercent()},
            {Manager, new ReduceTwentyFivePercent()},
            {Tester, new ReduceTenPercent()}
        };

        public Office(int code)
        {
            Code = code;

            if (Rule() == null)
                throw new NotImplementedException("Rule not defined!");
        }

        public ICalculationRule Rule()
        {
            return Rules.GetValueOrDefault(Code);
        }
    }
}