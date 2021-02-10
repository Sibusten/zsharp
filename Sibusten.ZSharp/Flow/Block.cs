using System;
using System.Collections.Generic;
using Sibusten.ZSharp.Output;
using Sibusten.ZSharp.Variables;

namespace Sibusten.ZSharp.Flow
{
    public class Block
    {
        internal const int MaxRegisters = 52;

        private readonly Block? _parent;
        internal object[] Registers = new object[MaxRegisters];
        private List<Action<Block>> _statements = new List<Action<Block>>();

        public Block(Block? parent = null)
        {
            _parent = parent;
        }

        public void AddStatement(Action<Block> statement)
        {
            _statements.Add(statement);
        }

        private Block? Execute()
        {
            foreach (Action<Block> statement in _statements)
            {
                statement(this);
            }

            // TODO: Block shouldn't be executed by itself. Need a top level class to start the whole thing
            return _parent;
        }

        public RegisterSelector<VariableSelector<Block>> s => new RegisterSelector<VariableSelector<Block>>(registerCallback =>
        {
            return new VariableSelector<Block>(variableCallback =>
            {
                AddStatement(context => context.Registers[registerCallback(context)] = variableCallback(context));
                return this;
            });
        });

        public OutputSelector<Block> o => new OutputSelector<Block>(this, this);

        public Block? Z => Execute();
    }
}
