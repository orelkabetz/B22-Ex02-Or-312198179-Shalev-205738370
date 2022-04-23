﻿using System;
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
        Player m_playerOne, m_playerTwo;
        public GameState currentState
        {
            get { return m_currentState; }
            set { m_currentState = value; }
        }
        public Game(int boardSize, string playerOneName, string playerTwoName)
        {
            m_currentState = new GameState(boardSize);
            m_rounds = 0;
            m_isFinished = false;
            m_playerOne = new Player(playerOneName);
            m_playerTwo = new Player(playerTwoName);
        }

        public void makeMove(string m_currentMove, ShapeWrapper playerTurn)
        {
            if (m_currentState.playerTurn.getShapeChar() == 'X')
            {
                Move currentMove = new Move(m_currentMove, m_playerOne);
            }
            else
            {
                Move currentMove = new Move(m_currentMove, m_playerTwo);
            }

        }
    }
}