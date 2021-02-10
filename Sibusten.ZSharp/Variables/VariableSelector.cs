using System;
using Sibusten.ZSharp.Flow;
using Sibusten.ZSharp.Variables.Builders;
using Sibusten.ZSharp.Variables.Operators;

namespace Sibusten.ZSharp.Variables
{
    public class VariableSelector<TNext> : Chainable<object, TNext>
    {
        public VariableSelector(Func<Func<Context, object>, TNext> callback) : base(callback) { }

        public BooleanVariableBuilder<TNext> b => new BooleanVariableBuilder<TNext>(valueCallback => Callback(context => valueCallback(context)));
        public NumericVariableBuilder<TNext> n => new NumericVariableBuilder<TNext>(valueCallback => Callback(context => valueCallback(context)));
        public OperatorSelector<TNext> o => new OperatorSelector<TNext>(operatorCallback => Callback(context => operatorCallback(context)));
        public RegisterSelector<TNext> r => new RegisterSelector<TNext>(registerCallback => Callback(context => context.Registers[registerCallback(context)]));
        public StringVariableBuilder<TNext> s => new StringVariableBuilder<TNext>(valueCallback => Callback(context => valueCallback(context)));
    }
}
