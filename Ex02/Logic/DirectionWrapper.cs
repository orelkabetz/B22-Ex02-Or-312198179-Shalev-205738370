using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class DirectionWrapper
    {
        private eDirection m_direction;
        public eDirection Direction
        {
            get { return m_direction; }
            set { m_direction = value; }
        }

        public enum eDirection 
        {
            Backward = 0,
            Forward = 1,
        }
    }
}
