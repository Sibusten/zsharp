using System;

namespace Sibusten.ZSharp.Flow
{
    public class Chainable<TOutput, TNext>
    {
        internal readonly Func<TOutput, TNext> Callback;

        public Chainable(Func<TOutput, TNext> callback)
        {
            Callback = callback;
        }
    }
}
