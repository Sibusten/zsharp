using System;

namespace Sibusten.ZSharp.Flow
{
    public class Chainable<TOutput, TNext>
    {
        internal readonly Func<Func<Block, TOutput>, TNext> Callback;

        public Chainable(Func<Func<Block, TOutput>, TNext> callback)
        {
            Callback = callback;
        }
    }
}
