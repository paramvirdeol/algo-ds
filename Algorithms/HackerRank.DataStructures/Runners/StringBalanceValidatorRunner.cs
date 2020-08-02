using HackerRank.DataStructures.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Runners
{    
    public class StringBalanceValidatorRunner : IRunner
    {
        Dictionary<string, bool> _checklist;
        IStringBalanceValidator _validator;
        public StringBalanceValidatorRunner(IStringBalanceValidator validator)
        {
            _checklist = new Dictionary<string, bool>();
            _validator = validator;
            AddChecklistItems();
        }
        private void AddChecklistItems()
        {
            // Positive cases
            _checklist.Add("{}()[{}]", true);            
            _checklist.Add("[({})]", true);
            _checklist.Add("({[]})", true);

            // Negative cases
            _checklist.Add("[({)}]", false);
            _checklist.Add("({[})", false);
            _checklist.Add("()}[]", false);

            // Final case
            _checklist.Add("{()[{({})[]()}]}([])", true);
        }

        public void Run()
        {
            var defaultColor = Console.ForegroundColor;
            foreach (var item in _checklist)
            {
                var result = _validator.IsBalanced(item.Key);                
                if (result == item.Value)
                {
                    if (Console.ForegroundColor != defaultColor)
                    {
                        Console.ForegroundColor = defaultColor;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"Value: {item.Key}, Expected: {item.Value}, Actual: {result} ");
                
            }
        }
    }


}

