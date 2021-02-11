using System;

namespace Sibusten.ZSharp.Flow
{
    public class WhileLoop<TNext>
    {
        public WhileLoop(TNext next, Context globalContext, Func<Context, object> conditionCallback)
        {
            ConditionCallback = conditionCallback;
            WhileBlock = new Block<TNext>(next, globalContext);
        }

        internal void Execute(Context context)
        {
            while ((dynamic)ConditionCallback(context))
            {
                WhileBlock.Execute();
            }
        }

        internal Func<Context, object> ConditionCallback;
        internal Block<TNext> WhileBlock;
    }
}
