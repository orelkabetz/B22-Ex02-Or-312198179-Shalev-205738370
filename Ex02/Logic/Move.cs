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
            m_startPosition = new Position(startRow - 'A', startCol - 'A');
            m_endPosition = new Position(endRow - 'A', endCol - 'A');
            
        }
    }

}
