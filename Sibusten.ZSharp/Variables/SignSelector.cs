using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables
{
    /// <summary>
    /// Returns true if positive, false if negative
    /// </summary>
    public class SignSelector<TNext> : Chainable<bool, TNext>
    {
        public SignSelector(Func<Func<Context, bool>, TNext> callback) : base(callback) { }

        /// <summary>
        /// Negative
        /// </summary>
        public TNext n => Callback(context => false);

        /// <summary>
        /// Positive
        /// </summary>
        public TNext p => Callback(context => true);
    }
}
