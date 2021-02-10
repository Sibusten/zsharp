using System;
using System.Collections.Generic;
using Sibusten.ZSharp.Output;
using Sibusten.ZSharp.Variables;

namespace Sibusten.ZSharp.Flow
{
    public class Block<TNext>
    {
        private readonly TNext _parent;
        private List<Action<Context>> _statements = new List<Action<Context>>();
        private Context _context = new Context();

        public Block(TNext parent)
        {
            _parent = parent;
        }

        public void AddStatement(Action<Context> statement)
        {
            _statements.Add(statement);
        }

        internal void Execute()
        {
            foreach (Action<Context> statement in _statements)
            {
                statement(_context);
            }
        }

        public RegisterSelector<VariableSelector<Block<TNext>>> s => new RegisterSelector<VariableSelector<Block<TNext>>>(registerCallback =>
        {
            return new VariableSelector<Block<TNext>>(variableCallback =>
            {
                AddStatement(context => context.Registers[registerCallback(context)] = variableCallback(context));
                return this;
            });
        });

        public OutputSelector<TNext, Block<TNext>> o => new OutputSelector<TNext, Block<TNext>>(this, this);

        public TNext Z => _parent;
    }
}
