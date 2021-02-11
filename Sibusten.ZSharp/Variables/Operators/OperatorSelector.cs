using System;
using Sibusten.ZSharp.Flow;

namespace Sibusten.ZSharp.Variables.Operators
{
    public class OperatorSelector<TNext> : Chainable<object, TNext>
    {
        public OperatorSelector(Func<Func<Context, object>, TNext> callback) : base(callback) { }

        internal VariableSelector<TNext> UnaryOp(Func<dynamic, object> op)
        {
            return new VariableSelector<TNext>(variableCallback =>
            {
                return Callback(context => op(variableCallback(context)));
            });
        }

        internal VariableSelector<VariableSelector<TNext>> BinaryOp(Func<dynamic, dynamic, object> op)
        {
            return new VariableSelector<VariableSelector<TNext>>(firstVarCallback =>
            {
                return new VariableSelector<TNext>(secondVarCallback =>
                {
                    return Callback(context => op(firstVarCallback(context), secondVarCallback(context)));
                });
            });
        }

        /// <summary>
        /// Addition
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> a => BinaryOp((a, b) => a + b);

        /// <summary>
        /// Subtraction
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> s => BinaryOp((a, b) => a - b);

        /// <summary>
        /// Multiplication
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> m => BinaryOp((a, b) => a * b);

        /// <summary>
        /// Division
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> d => BinaryOp((a, b) => a / b);

        /// <summary>
        /// Modulo
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> M => BinaryOp((a, b) => a % b);



        /// <summary>
        /// Equal to
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> e => BinaryOp((a, b) => a == b);

        /// <summary>
        /// Not equal to
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> E => BinaryOp((a, b) => a != b);

        /// <summary>
        /// Less than
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> l => BinaryOp((a, b) => a < b);

        /// <summary>
        /// Less than or equal to
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> L => BinaryOp((a, b) => a <= b);

        /// <summary>
        /// Greater than
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> g => BinaryOp((a, b) => a > b);

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> G => BinaryOp((a, b) => a >= b);



        /// <summary>
        /// Logical Not
        /// </summary>
        public VariableSelector<TNext> n => UnaryOp(a => !a);

        /// <summary>
        /// Logical And
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> A => BinaryOp((a, b) => a && b);

        /// <summary>
        /// Logical Or
        /// </summary>
        public VariableSelector<VariableSelector<TNext>> O => BinaryOp((a, b) => a || b);
    }
}
