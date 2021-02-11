namespace Sibusten.ZSharp.Flow
{
    public class Context
    {
        internal Context GlobalContext;
        internal const int MaxRegisters = 52;
        internal object[] Registers = new object[MaxRegisters];

        public Context(Context? globalContext = null)
        {
            if (globalContext is null)
            {
                // This is the global context
                GlobalContext = this;
            }
            else
            {
                GlobalContext = globalContext;
            }
        }
    }
}
