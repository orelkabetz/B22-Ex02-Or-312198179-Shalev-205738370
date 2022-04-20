using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class Piece
    {
        private ShapeWrapper.eShape m_shape; // Not sure about it
        private bool m_isKing = false;
        public Piece(ShapeWrapper.eShape colour)
        {
            m_shape = colour;
        }
        public char getShape()
        {
            if (m_shape == ShapeWrapper.eShape.O)
            {
                return 'O';
            }    
            else if (m_shape == ShapeWrapper.eShape.X)
            {
                return 'X';
            }
            else
            {
                return ' ';
            }
        }
    }
}
