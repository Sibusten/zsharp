using System;
using System.Text;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Builders
{
    public class NumericVariableBuilder<TNext> : Chainable<long, TNext>
    {
        private StringBuilder _sb = new StringBuilder();

        public NumericVariableBuilder(Func<Func<Context, long>, TNext> callback) : base(callback) { }

        internal NumericVariableBuilder<TNext> AppendChar(char c)
        {
            _sb.Append(c);
            return this;
        }

        internal long GetValue()
        {
            return long.Parse(_sb.ToString());
        }

        /// <summary>
        /// 0
        /// </summary>
        public NumericVariableBuilder<TNext> a => AppendChar('0');

        /// <summary>
        /// 1
        /// </summary>
        public NumericVariableBuilder<TNext> b => AppendChar('1');

        /// <summary>
        /// 2
        /// </summary>
        public NumericVariableBuilder<TNext> c => AppendChar('2');

        /// <summary>
        /// 3
        /// </summary>
        public NumericVariableBuilder<TNext> d => AppendChar('3');

        /// <summary>
        /// 4
        /// </summary>
        public NumericVariableBuilder<TNext> e => AppendChar('4');

        /// <summary>
        /// 5
        /// </summary>
        public NumericVariableBuilder<TNext> f => AppendChar('5');

        /// <summary>
        /// 6
        /// </summary>
        public NumericVariableBuilder<TNext> g => AppendChar('6');

        /// <summary>
        /// 7
        /// </summary>
        public NumericVariableBuilder<TNext> h => AppendChar('7');

        /// <summary>
        /// 8
        /// </summary>
        public NumericVariableBuilder<TNext> i => AppendChar('8');

        /// <summary>
        /// 9
        /// </summary>
        public NumericVariableBuilder<TNext> j => AppendChar('9');

        /// <summary>
        /// End
        /// </summary>
        public TNext Z => Callback(context => GetValue());
    }
}
