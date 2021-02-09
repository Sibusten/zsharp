using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Builders
{
    public class BooleanVariableBuilder<TNext> : Chainable<bool, TNext>
    {
        public BooleanVariableBuilder(Func<bool, TNext> callback) : base(callback) { }

        public TNext t => Callback(true);
        public TNext f => Callback(false);
    }
}
