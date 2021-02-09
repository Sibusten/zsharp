using System;
using Sibusten.ZSharp.Flow;
using Sibusten.ZSharp.Variables.Builders;

namespace Sibusten.ZSharp.Variables
{
    public class VariableSelector<TNext> : Chainable<object, TNext>
    {
        private readonly ZEngine _engine;

        public VariableSelector(ZEngine engine, Func<object, TNext> callback) : base(callback)
        {
            _engine = engine;
        }

        public BooleanVariableBuilder<TNext> b => new BooleanVariableBuilder<TNext>(value => Callback(value));
        public RegisterSelector<TNext> r => new RegisterSelector<TNext>(register => Callback(_engine.Registers[register]));
        public StringVariableBuilder<TNext> s => new StringVariableBuilder<TNext>(Callback);
    }
}
