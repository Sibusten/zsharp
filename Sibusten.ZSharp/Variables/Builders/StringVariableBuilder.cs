using System;
using System.Text;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Definitions
{
    public class StringVariableBuilder<TNext> : Chainable<string, TNext>
    {
        private StringBuilder _sb = new StringBuilder();

        public StringVariableBuilder(Func<string, TNext> callback) : base(callback) { }

        internal StringVariableBuilder<TNext> AppendChar(char c)
        {
            _sb.Append(c);
            return this;
        }

        internal string GetString()
        {
            return _sb.ToString();
        }

        public StringVariableBuilder<TNext> a => AppendChar('a');
        public StringVariableBuilder<TNext> b => AppendChar('b');
        public StringVariableBuilder<TNext> c => AppendChar('c');
        public StringVariableBuilder<TNext> d => AppendChar('d');
        public StringVariableBuilder<TNext> e => AppendChar('e');
        public StringVariableBuilder<TNext> f => AppendChar('f');
        public StringVariableBuilder<TNext> g => AppendChar('g');
        public StringVariableBuilder<TNext> h => AppendChar('h');
        public StringVariableBuilder<TNext> i => AppendChar('i');
        public StringVariableBuilder<TNext> j => AppendChar('j');
        public StringVariableBuilder<TNext> k => AppendChar('k');
        public StringVariableBuilder<TNext> l => AppendChar('l');
        public StringVariableBuilder<TNext> m => AppendChar('m');
        public StringVariableBuilder<TNext> n => AppendChar('n');
        public StringVariableBuilder<TNext> o => AppendChar('o');
        public StringVariableBuilder<TNext> p => AppendChar('p');
        public StringVariableBuilder<TNext> q => AppendChar('q');
        public StringVariableBuilder<TNext> r => AppendChar('r');
        public StringVariableBuilder<TNext> s => AppendChar('s');
        public StringVariableBuilder<TNext> t => AppendChar('t');
        public StringVariableBuilder<TNext> u => AppendChar('u');
        public StringVariableBuilder<TNext> v => AppendChar('v');
        public StringVariableBuilder<TNext> w => AppendChar('w');
        public StringVariableBuilder<TNext> x => AppendChar('x');
        public StringVariableBuilder<TNext> y => AppendChar('y');
        public StringVariableBuilder<TNext> z => AppendChar('z');
        public StringVariableBuilder<TNext> A => AppendChar('A');
        public StringVariableBuilder<TNext> B => AppendChar('B');
        public StringVariableBuilder<TNext> C => AppendChar('C');
        public StringVariableBuilder<TNext> D => AppendChar('D');
        public StringVariableBuilder<TNext> E => AppendChar('E');
        public StringVariableBuilder<TNext> F => AppendChar('F');
        public StringVariableBuilder<TNext> G => AppendChar('G');
        public StringVariableBuilder<TNext> H => AppendChar('H');
        public StringVariableBuilder<TNext> I => AppendChar('I');
        public StringVariableBuilder<TNext> J => AppendChar('J');
        public StringVariableBuilder<TNext> K => AppendChar('K');
        public StringVariableBuilder<TNext> L => AppendChar('L');
        public StringVariableBuilder<TNext> M => AppendChar('M');
        public StringVariableBuilder<TNext> N => AppendChar('N');
        public StringVariableBuilder<TNext> O => AppendChar('O');
        public StringVariableBuilder<TNext> P => AppendChar('P');
        public StringVariableBuilder<TNext> Q => AppendChar('Q');
        public StringVariableBuilder<TNext> R => AppendChar('R');
        public StringVariableBuilder<TNext> S => AppendChar('S');
        public StringVariableBuilder<TNext> T => AppendChar('T');
        public StringVariableBuilder<TNext> U => AppendChar('U');
        public StringVariableBuilder<TNext> V => AppendChar('V');
        public StringVariableBuilder<TNext> W => AppendChar('W');
        public StringVariableBuilder<TNext> X => AppendChar('X');
        public StringVariableBuilder<TNext> Y => AppendChar('Y');

        /// <summary>
        /// Enter a special character (or 'Z')
        /// </summary>
        public SpecialCharacterEntry<TNext> Z => new SpecialCharacterEntry<TNext>(this);
    }

    public class SpecialCharacterEntry<TNext>
    {
        private StringVariableBuilder<TNext> _svb;

        public SpecialCharacterEntry(StringVariableBuilder<TNext> svb)
        {
            _svb = svb;
        }

        public StringVariableBuilder<TNext> e => _svb.AppendChar('!');
        public StringVariableBuilder<TNext> n => _svb.AppendChar('\n');
        public StringVariableBuilder<TNext> s => _svb.AppendChar(' ');

        public StringVariableBuilder<TNext> Z => _svb.AppendChar('Z');

        /// <summary>
        /// Finish the string entry
        /// </summary>
        public TNext z => _svb.Callback(_svb.GetString());
    }
}
