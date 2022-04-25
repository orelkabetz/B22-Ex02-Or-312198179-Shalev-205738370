using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class Move
    {
        private Position m_startPosition;
        private Position m_endPosition;
        private Player m_sender;
        public Move(string move, Player player)
        {
            char startCol = move[0];
            char startRow = move[1];
            char endCol = move[3];
            char endRow = move[4];
            m_startPosition = new Position(startRow - 'a', startCol - 'A');
            m_endPosition = new Position(endRow - 'a', endCol - 'A');
            m_sender = player;
        }
        public Position startPosition
        {
            get { return m_startPosition; }
            set { m_startPosition = value; }
        }
        public Position endPosition
        {
            get { return m_endPosition; }
            set { m_endPosition = value; }
        }
        public Player sender
        {
            get { return m_sender; }
            set { m_sender = value; }
        }
    }

}
