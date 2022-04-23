using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class GameState
    {
        private GameState m_previous, m_next;
        private ShapeWrapper m_playerTurn;
        private Piece[,] m_boardArray;
        public Piece[,] boardArray
        { 
            get { return m_boardArray; } 
            set { m_boardArray = value; }
        }
        public GameState(int size)
        {
            m_boardArray = new Piece[size, size];
            m_playerTurn = new ShapeWrapper('X');
        }
        public ShapeWrapper playerTurn
        {
            get { return m_playerTurn; }
            set { m_playerTurn = value; }
        }
        private void switchTurn()
        {
            //תשנה תור
        }
    }
}
