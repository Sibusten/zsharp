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
        public NumericVariableBuilder<SignSelector<TNext>> n => new NumericVariableBuilder<SignSelector<TNext>>(valueCallback =>
        {
            return new SignSelector<TNext>(signCallback => Callback(context =>
            {
                long value = valueCallback(context);

                // If sign is negative, negate value
                if (!signCallback(context))
                {
                    value = -value;
                }

                return value;
            }));
        });
        public OperatorSelector<TNext> o => new OperatorSelector<TNext>(operatorCallback => Callback(context => operatorCallback(context)));

        public RegisterTypeSelector<RegisterSelector<TNext>> r => new RegisterTypeSelector<RegisterSelector<TNext>>(registerTypeCallback =>
        {
            return new RegisterSelector<TNext>(registerCallback => Callback(context =>
            {
                bool useGlobal = registerTypeCallback(context);

                if (useGlobal)
                {
                    return context.GlobalContext.Registers[registerCallback(context)];
                }
                else
                {
                    return context.Registers[registerCallback(context)];
                }
            }));
        });

        public StringVariableBuilder<TNext> s => new StringVariableBuilder<TNext>(valueCallback => Callback(context => valueCallback(context)));
    }
}
