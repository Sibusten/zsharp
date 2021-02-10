using System;
using System.Collections.Generic;
using Sibusten.ZSharp.Output;
using Sibusten.ZSharp.Variables;

namespace Sibusten.ZSharp.Flow
{
    public class Block
    {
        internal const int MaxRegisters = 52;

        internal object[] Registers = new object[MaxRegisters];

        private List<Action<Block>> _statements = new List<Action<Block>>();

        public void AddStatement(Action<Block> statement)
        {
            _statements.Add(statement);
        }

        public void Execute()
        {
            foreach (Action<Block> statement in _statements)
            {
                statement(this);
            }
        }

        public RegisterSelector<VariableSelector<Block>> s => new RegisterSelector<VariableSelector<Block>>(register =>
        {
            return new VariableSelector<Block>(this, variable =>
            {
                Registers[register] = variable;
                return this;
            });
        });

        public OutputSelector<Block> o => new OutputSelector<Block>(this, this);
    }
}
