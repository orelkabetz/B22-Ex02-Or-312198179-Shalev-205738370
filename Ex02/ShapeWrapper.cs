using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    public class ShapeWrapper
    {
        private eShape m_shape;
        public eShape Shape
        {
            get { return m_shape; }
            set { m_shape = value; }
        }
        public enum eShape
        {
            O = 0,
            X = 1,
            E = 2,
        }
        public ShapeWrapper(char shape)
        {
            switch (shape)
            {
                case 'O':
                    m_shape = eShape.O;
                    break;
                case 'X':
                    m_shape = eShape.X;
                    break;
                case 'E':
                    m_shape= eShape.E;
                    break;
                default:
                    m_shape = eShape.E;
                    break;
            }
        }
        public char getShapeChar()
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
