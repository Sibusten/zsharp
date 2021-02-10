using System;

namespace Sibusten.ZSharp.Flow
{
    public class Chainable<TOutput, TNext>
    {
        internal readonly Func<Func<Context, TOutput>, TNext> Callback;

        public Chainable(Func<Func<Context, TOutput>, TNext> callback)
        {
            Callback = callback;
        }
    }
}
