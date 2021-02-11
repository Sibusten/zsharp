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
        private Context _context;

        public Block(TNext parent, Context globalContext)
        {
            _parent = parent;
            _context = new Context(globalContext);
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

        public RegisterTypeSelector<RegisterSelector<VariableSelector<Block<TNext>>>> s => new RegisterTypeSelector<RegisterSelector<VariableSelector<Block<TNext>>>>(registerTypeCallback =>
        {
            return new RegisterSelector<VariableSelector<Block<TNext>>>(registerCallback =>
            {
                return new VariableSelector<Block<TNext>>(variableCallback =>
                {
                    AddStatement(context =>
                    {
                        bool useGlobal = registerTypeCallback(context);

                        if (useGlobal)
                        {
                            context.GlobalContext.Registers[registerCallback(context)] = variableCallback(context);
                        }
                        else
                        {
                            context.Registers[registerCallback(context)] = variableCallback(context);
                        }
                    });

                    return this;
                });
            });
        });

        public OutputSelector<TNext, Block<TNext>> o => new OutputSelector<TNext, Block<TNext>>(this, this);

        public VariableSelector<Block<IfStatement<Block<TNext>>>> i => new VariableSelector<Block<IfStatement<Block<TNext>>>>(conditionCallback =>
        {
            IfStatement<Block<TNext>> ifStatement = new IfStatement<Block<TNext>>(this, _context.GlobalContext, conditionCallback);
            AddStatement(context => ifStatement.Execute(context));

            return ifStatement.IfBlock;
        });

        public VariableSelector<Block<Block<TNext>>> w => new VariableSelector<Block<Block<TNext>>>(conditionCallback =>
        {
            WhileLoop<Block<TNext>> whileLoop = new WhileLoop<Block<TNext>>(this, _context.GlobalContext, conditionCallback);
            AddStatement(context => whileLoop.Execute(context));

            return whileLoop.WhileBlock;
        });

        public TNext Z => _parent;
    }
}
