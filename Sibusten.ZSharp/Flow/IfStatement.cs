using System;

namespace Sibusten.ZSharp.Flow
{
    public class IfStatement<TNext>
    {
        private readonly TNext _next;

        public IfStatement(TNext next, Func<Context, object> conditionCallback)
        {
            _next = next;

            ConditionCallback = conditionCallback;
            IfBlock = new Block<IfStatement<TNext>>(this);
            ElseBlock = new Block<TNext>(next);
        }

        internal void Execute(Context context)
        {
            if ((dynamic)ConditionCallback(context))
            {
                IfBlock.Execute();
            }
            else
            {
                ElseBlock.Execute();
            }
        }

        internal Func<Context, object> ConditionCallback;
        internal Block<IfStatement<TNext>> IfBlock;
        internal Block<TNext> ElseBlock;

        public Block<TNext> e => ElseBlock;

        public TNext Z => _next;
    }
}
