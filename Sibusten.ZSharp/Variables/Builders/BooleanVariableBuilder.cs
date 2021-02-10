using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Builders
{
    public class BooleanVariableBuilder<TNext> : Chainable<bool, TNext>
    {
        public BooleanVariableBuilder(Func<Func<Block, bool>, TNext> callback) : base(callback) { }

        public TNext t => Callback(context => true);
        public TNext f => Callback(context => false);
    }
}
