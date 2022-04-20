using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class Game
    {
        private GameState m_currentState;
        private int m_rounds;
        private bool m_isFinished;
        private string[] m_results;
        public GameState currentState
        {
            get { return m_currentState; }
            set { m_currentState = value; }
        }
        public Game(int boardSize)
        {
            m_currentState = new GameState(boardSize, boardSize);
            m_rounds = 0;
            m_isFinished = false;
        }
        public void createMove(string currentMove)
        {

        }
    }
}
