using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic
{
    public class Player
    {
        private string m_nickName;
        private ShapeWrapper m_shape; // Not sure about it
        private int m_score;
        private int m_numOfWins;
        private int m_numOfDraws;
        public string nickName
        {
            get { return m_nickName; }
            set { m_nickName = value; }
        }
        public ShapeWrapper shape
        {
            get { return m_shape; }
            set { m_shape = value; }
        }
        public int score
        {
            get { return m_score; }
            set { m_score = value; }
        }
        public int numOfWins
        {
            get { return m_numOfWins; }
            set { m_numOfWins = value; }
        }
        public int numOfDraws
        {
            get { return m_numOfDraws; }
            set { m_numOfDraws = value; }
        }
        public Player(string nickName)
        {
            m_nickName = nickName;
            m_score = 0;
            m_numOfWins = 0;
            m_numOfDraws = 0;
        }
    }
}
