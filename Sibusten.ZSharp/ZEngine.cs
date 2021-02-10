using Sibusten.ZSharp.Flow;

public static class Z
{
    public static Block<ZEngine> z
    {
        get
        {
            ZEngine engine = new ZEngine();
            engine.RootBlock = new Block<ZEngine>(engine);
            return engine.RootBlock;
        }
    }

    public class ZEngine
    {
        public Block<ZEngine>? RootBlock;

        public End z
        {
            get
            {
                RootBlock!.Execute();
                return new End();
            }
        }

        public class End { }
    }
}
