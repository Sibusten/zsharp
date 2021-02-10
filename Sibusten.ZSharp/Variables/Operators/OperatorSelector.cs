using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Operators
{
    public class OperatorSelector<TNext> : Chainable<object, TNext>
    {
        private readonly Block _block;

        public OperatorSelector(Block block, Func<object, TNext> callback) : base(callback)
        {
            _block = block;
        }

        public VariableSelector<VariableSelector<TNext>> a => new VariableSelector<VariableSelector<TNext>>(_block, variable1 =>
            new VariableSelector<TNext>(_block, variable2 =>
                Callback((dynamic)variable1 + (dynamic)variable2)));
        public VariableSelector<TNext> n => new VariableSelector<TNext>(_block, variable => Callback(!(dynamic)variable));
    }
}
