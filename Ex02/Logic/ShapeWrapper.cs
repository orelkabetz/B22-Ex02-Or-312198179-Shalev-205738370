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
    }
}
