using System;
using Sibusten.ZSharp.Flow;
using Sibusten.ZSharp.Variables.Definitions;

namespace Sibusten.ZSharp.Variables
{
    public class VariableSelector<TNext> : Chainable<object, TNext>
    {
        public VariableSelector(Func<object, TNext> callback) : base(callback) { }

        public StringVariableBuilder<TNext> s => new StringVariableBuilder<TNext>(Callback);
    }
}
