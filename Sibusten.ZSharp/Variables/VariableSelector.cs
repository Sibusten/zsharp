using System;
using Sibusten.ZSharp.Flow;
using Sibusten.ZSharp.Variables.Builders;
using Sibusten.ZSharp.Variables.Operators;

namespace Sibusten.ZSharp.Variables
{
    public class VariableSelector<TNext> : Chainable<object, TNext>
    {
        private readonly Block _block;

        public VariableSelector(Block block, Func<object, TNext> callback) : base(callback)
        {
            _block = block;
        }

        public BooleanVariableBuilder<TNext> b => new BooleanVariableBuilder<TNext>(value => Callback(value));
        public OperatorSelector<TNext> o => new OperatorSelector<TNext>(_block, Callback);
        public RegisterSelector<TNext> r => new RegisterSelector<TNext>(register => Callback(_block.Registers[register]));
        public StringVariableBuilder<TNext> s => new StringVariableBuilder<TNext>(Callback);
    }
}
