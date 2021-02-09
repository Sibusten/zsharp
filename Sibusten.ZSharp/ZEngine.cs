using Sibusten.ZSharp;
using Sibusten.ZSharp.Output;

public static class Z
{
    public static ZEngine z => new ZEngine();
}

namespace Sibusten.ZSharp
{
    public class ZEngine
    {
        public OutputSelector<ZEngine> o => new OutputSelector<ZEngine>(this);
    }
}
