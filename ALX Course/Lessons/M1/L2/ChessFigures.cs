using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M1.L2.Enums
{
    public class ChessFigures
    {
        public ChessFigureTypes FigureTypes;
        public ChessColor FigureColor;

        public ChessFigures() { }

        public ChessFigures(ChessFigureTypes chessFigureTypes, ChessColor chessColor)
        {
            FigureTypes = chessFigureTypes;
            FigureColor = chessColor;
        }
    }
}
