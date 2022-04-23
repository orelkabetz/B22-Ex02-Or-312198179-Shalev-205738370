using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex02.ConsoleUtils;

namespace Ex02.ConsoleUserInterface
{
    public class Messages
    {
        private string m_playerOneName;
        private string m_playerTwoName;
        private int m_boardSize;
        private int m_oneOrTwoPlayers;
        public string PlayerOneName
        {
            get { return m_playerOneName; }
            set { m_playerOneName = value; }
        }
        public string PlayerTwoName
        {
            get { return m_playerTwoName; }
            set { m_playerTwoName = value; }
        }
        public int BoardSize
        {
            get { return m_boardSize; }
            set { m_boardSize = value; }
        }
        public int OneOrTwoPlayers
        {
            get { return m_oneOrTwoPlayers; }
            set { m_oneOrTwoPlayers = value; }
        }
        public void start()
        {
            printHello();
            defineSettings();
            //Console.WriteLine("BYE!");
            //Console.ReadLine();
        }
        private void printHello()
        {
            string hello = string.Format(
@"
    Hello and welocme to:
        # CHECKERS #");
            Console.WriteLine(hello);
        }
        private void defineSettings()
        {
            m_playerOneName = getNameFromUser();
            getSize();
            getOneOrTwoPlayers();
        }
        private string getNameFromUser()
        {
        string getNameMessage = string.Format(
@"
    Please Enter Your Name:
");
            Console.WriteLine(getNameMessage);
            System.Console.SetCursorPosition(10, 5);
            return Console.ReadLine();
        }
        private void getSize()
        {
            string getSizeMessage = string.Format(
@"
    Please choose the size of the board

                (1)  6x6
                (2)  8x8
                (3) 10x10
");
            Screen.Clear();
            Console.WriteLine(getSizeMessage);
            System.Console.SetCursorPosition(17, 7);
            //m_boardSize = Int32.Parse(Console.ReadLine());
            Int32.TryParse(Console.ReadLine(), out m_boardSize);
            convertChoiceToActualSize();
            return;
        }
        private void convertChoiceToActualSize()
        {
            if (m_boardSize == 1)
            {
                m_boardSize = 6;
            }
            else if (m_boardSize == 2)
            {
                m_boardSize = 8;    
            }
            else if (m_boardSize == 3)
            {
                m_boardSize = 10;
            }    
        }
        private void getOneOrTwoPlayers()
        {
            string getPlayersNumberMessage = string.Format(
@"
    Please choose how many players

            (1)  1 player
            (2)  2 players
");
            Screen.Clear();
            Console.WriteLine(getPlayersNumberMessage);
            System.Console.SetCursorPosition(17, 6);
           // m_oneOrTwoPlayers = Int32.Parse(Console.ReadLine());
            Int32.TryParse(Console.ReadLine(), out m_oneOrTwoPlayers);
            if (m_oneOrTwoPlayers == 2)
            {
                Screen.Clear();
                string hiSecondPlayer = string.Format(
@"
        Hi 2nd Player!");
                Console.WriteLine(hiSecondPlayer);
                m_playerTwoName = getNameFromUser();
            }
            else
            {
                m_playerTwoName = "Computer";
            }
            return;
        }
        public void printInvalidInput()
        {
            string invalid = string.Format(
@"
This move is not valid!
A valid move should look like this 'Gf>He'
Please try again: ");
            System.Console.SetCursorPosition(0, BoardSize*2+1);
            Console.WriteLine(invalid);
        }
        public void displayTurn(ShapeWrapper playerTurn)
        {
            // Print a message to the user which one's turn, and to make a move

            if (playerTurn.getShapeChar() == 'X')
            {
                Console.WriteLine(PlayerOneName + "'s turn : ({0})", playerTurn.getShapeChar());
            }
            else
            {
                Console.WriteLine(PlayerTwoName + "'s turn : ({0})", playerTurn.getShapeChar());
            }
        }
    }
}
