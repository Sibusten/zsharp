using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables
{
    /// <summary>
    /// Returns true for global context, false for local
    /// </summary>
    public class RegisterTypeSelector<TNext> : Chainable<bool, TNext>
    {
        public RegisterTypeSelector(Func<Func<Context, bool>, TNext> callback) : base(callback) { }

        /// <summary>
        /// Global
        /// </summary>
        public TNext g => Callback(context => true);

        /// <summary>
        /// Local
        /// </summary>
        public TNext l => Callback(context => false);
    }
}
