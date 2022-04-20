using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class GameState
    {
        private GameState m_previous, m_next;
        private ShapeWrapper.eShape m_playerTurn;
        private Piece[,] m_boardArray;
        public Piece[,] boardArray
        { 
            get { return m_boardArray; } 
            set { m_boardArray = value; }
        }
        public GameState(int width, int height)
        {
            m_boardArray = new Piece[width, height];
        }
    }
}
