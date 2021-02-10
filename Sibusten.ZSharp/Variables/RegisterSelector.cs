using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables
{
    public class RegisterSelector<TNext> : Chainable<int, TNext>
    {
        public RegisterSelector(Func<Func<Block, int>, TNext> callback) : base(callback) { }

        public TNext a => Callback(context => 0);
        public TNext b => Callback(context => 1);
        public TNext c => Callback(context => 2);
        public TNext d => Callback(context => 3);
        public TNext e => Callback(context => 4);
        public TNext f => Callback(context => 5);
        public TNext g => Callback(context => 6);
        public TNext h => Callback(context => 7);
        public TNext i => Callback(context => 8);
        public TNext j => Callback(context => 9);
        public TNext k => Callback(context => 10);
        public TNext l => Callback(context => 11);
        public TNext m => Callback(context => 12);
        public TNext n => Callback(context => 13);
        public TNext o => Callback(context => 14);
        public TNext p => Callback(context => 15);
        public TNext q => Callback(context => 16);
        public TNext r => Callback(context => 17);
        public TNext s => Callback(context => 18);
        public TNext t => Callback(context => 19);
        public TNext u => Callback(context => 20);
        public TNext v => Callback(context => 21);
        public TNext w => Callback(context => 22);
        public TNext x => Callback(context => 23);
        public TNext y => Callback(context => 24);
        public TNext z => Callback(context => 25);
        public TNext A => Callback(context => 26);
        public TNext B => Callback(context => 27);
        public TNext C => Callback(context => 28);
        public TNext D => Callback(context => 29);
        public TNext E => Callback(context => 30);
        public TNext F => Callback(context => 31);
        public TNext G => Callback(context => 32);
        public TNext H => Callback(context => 33);
        public TNext I => Callback(context => 34);
        public TNext J => Callback(context => 35);
        public TNext K => Callback(context => 36);
        public TNext L => Callback(context => 37);
        public TNext M => Callback(context => 38);
        public TNext N => Callback(context => 39);
        public TNext O => Callback(context => 40);
        public TNext P => Callback(context => 41);
        public TNext Q => Callback(context => 42);
        public TNext R => Callback(context => 43);
        public TNext S => Callback(context => 44);
        public TNext T => Callback(context => 45);
        public TNext U => Callback(context => 46);
        public TNext V => Callback(context => 47);
        public TNext W => Callback(context => 48);
        public TNext X => Callback(context => 49);
        public TNext Y => Callback(context => 50);
        public TNext Z => Callback(context => 51);
    }
}
