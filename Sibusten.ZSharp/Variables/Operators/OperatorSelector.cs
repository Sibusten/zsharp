using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Operators
{
    public class OperatorSelector<TNext> : Chainable<object, TNext>
    {
        private readonly ZEngine _engine;

        public OperatorSelector(ZEngine engine, Func<object, TNext> callback) : base(callback)
        {
            _engine = engine;
        }

        public VariableSelector<VariableSelector<TNext>> a => new VariableSelector<VariableSelector<TNext>>(_engine, variable1 =>
            new VariableSelector<TNext>(_engine, variable2 =>
                Callback((dynamic)variable1 + (dynamic)variable2)));
        public VariableSelector<TNext> n => new VariableSelector<TNext>(_engine, variable => Callback(!(dynamic)variable));
    }
}
