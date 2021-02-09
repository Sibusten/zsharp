using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables
{
    public class RegisterSelector<TNext> : Chainable<int, TNext>
    {
        public RegisterSelector(Func<int, TNext> callback) : base(callback) { }

        public TNext a => Callback(0);
        public TNext b => Callback(1);
        public TNext c => Callback(2);
        public TNext d => Callback(3);
        public TNext e => Callback(4);
        public TNext f => Callback(5);
        public TNext g => Callback(6);
        public TNext h => Callback(7);
        public TNext i => Callback(8);
        public TNext j => Callback(9);
        public TNext k => Callback(10);
        public TNext l => Callback(11);
        public TNext m => Callback(12);
        public TNext n => Callback(13);
        public TNext o => Callback(14);
        public TNext p => Callback(15);
        public TNext q => Callback(16);
        public TNext r => Callback(17);
        public TNext s => Callback(18);
        public TNext t => Callback(19);
        public TNext u => Callback(20);
        public TNext v => Callback(21);
        public TNext w => Callback(22);
        public TNext x => Callback(23);
        public TNext y => Callback(24);
        public TNext z => Callback(25);
        public TNext A => Callback(26);
        public TNext B => Callback(27);
        public TNext C => Callback(28);
        public TNext D => Callback(29);
        public TNext E => Callback(30);
        public TNext F => Callback(31);
        public TNext G => Callback(32);
        public TNext H => Callback(33);
        public TNext I => Callback(34);
        public TNext J => Callback(35);
        public TNext K => Callback(36);
        public TNext L => Callback(37);
        public TNext M => Callback(38);
        public TNext N => Callback(39);
        public TNext O => Callback(40);
        public TNext P => Callback(41);
        public TNext Q => Callback(42);
        public TNext R => Callback(43);
        public TNext S => Callback(44);
        public TNext T => Callback(45);
        public TNext U => Callback(46);
        public TNext V => Callback(47);
        public TNext W => Callback(48);
        public TNext X => Callback(49);
        public TNext Y => Callback(50);
        public TNext Z => Callback(51);
    }
}
