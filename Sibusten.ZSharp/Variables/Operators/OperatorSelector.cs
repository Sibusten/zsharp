using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Operators
{
    public class OperatorSelector<TNext> : Chainable<object, TNext>
    {
        public OperatorSelector(Func<Func<Block, object>, TNext> callback) : base(callback) { }

        public VariableSelector<VariableSelector<TNext>> a => new VariableSelector<VariableSelector<TNext>>(firstVarCallback =>
            new VariableSelector<TNext>(secondVarCallback =>
                Callback(context => (dynamic)firstVarCallback(context) + (dynamic)secondVarCallback(context))));

        public VariableSelector<TNext> n => new VariableSelector<TNext>(variableCallback => Callback(context => !(dynamic)variableCallback(context)));
    }
}
