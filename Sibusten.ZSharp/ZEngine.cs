using Sibusten.ZSharp;
using Sibusten.ZSharp.Output;
using Sibusten.ZSharp.Variables;

public static class Z
{
    public static ZEngine z => new ZEngine();
}

namespace Sibusten.ZSharp
{
    public class ZEngine
    {
        internal const int MaxRegisters = 52;

        internal object[] Registers = new object[MaxRegisters];

        public RegisterSelector<VariableSelector<ZEngine>> s => new RegisterSelector<VariableSelector<ZEngine>>(register =>
        {
            return new VariableSelector<ZEngine>(this, variable =>
            {
                Registers[register] = variable;
                return this;
            });
        });

        public OutputSelector<ZEngine> o => new OutputSelector<ZEngine>(this, this);
    }
}
