using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex02.Logic;
using Ex02.ConsoleUtils;

namespace Ex02.ConsoleUserInterface
{
    public class Controller
    {
        Game m_game;
        Messages m_messages = new Messages();
        private string m_currentMove;
        public void Run() // Maybe should be static and not object referenced
        {
            m_messages.start();
            createNewGame(m_messages.BoardSize);
            printBoard();
            // while (is not finished)
            getUserMove();
           // m_game.makeMove(m_currentMove);
            
        }
        public void createNewGame(int boardSize)
        {
            m_game = new Game(boardSize);
            intializeBoard(boardSize);
        }
        private void intializeBoard(int boardSize)
        {
            genereateOPieces(boardSize);
            generateEPieces(boardSize);
            genereateXPieces(boardSize);
        }
        private void genereateOPieces(int boardSize)
        {
            for (int i = 0; i < (boardSize / 2) - 1; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            m_game.currentState.boardArray[i, j] = generateNewEmptyPiece();
                        }
                        else
                        {
                            m_game.currentState.boardArray[i, j] = generateNewOPiece();
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            m_game.currentState.boardArray[i, j] = generateNewOPiece();
                        }
                        else
                        {
                            m_game.currentState.boardArray[i, j] = generateNewEmptyPiece();
                        }

                    }
                }
            }
        }
        private Piece generateNewOPiece()
        {
            return new Piece(ShapeWrapper.eShape.O);
        }
        private void generateEPieces(int boardSize)
        {
            for (int i = (boardSize / 2) - 1; i < (boardSize / 2) + 1; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    m_game.currentState.boardArray[i, j] = generateNewEmptyPiece();
                }
            }
        }
        private Piece generateNewEmptyPiece()
        {
            return new Piece(ShapeWrapper.eShape.E);
        }
        private void genereateXPieces(int boardSize)
        {
            for (int i = (boardSize / 2) +1; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 0)
                        {
                            m_game.currentState.boardArray[i, j] = generateNewXPiece();
                        }
                        else
                        {
                            m_game.currentState.boardArray[i, j] = generateNewEmptyPiece();
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            m_game.currentState.boardArray[i, j] = generateNewEmptyPiece();
                        }
                        else
                        {
                            m_game.currentState.boardArray[i, j] = generateNewXPiece();
                        }

                    }
                }
            }
        }
        private Piece generateNewXPiece()
        {
            return new Piece(ShapeWrapper.eShape.X);
        }
        private void printBoard()
        {
            Screen.Clear();
            object[] printableArray = createPrintableArray();
            string board6 = string.Format(
@"   A   B   C   D   E   F  
=========================
a| {0} | {1} | {2} | {3} | {4} | {5} |
=========================
b| {6} | {7} | {8} | {9} | {10} | {11} |
=========================
c| {12} | {13} | {14} | {15} | {16} | {17} |
=========================
d| {18} | {19} | {20} | {21} | {22} | {23} |
=========================
e| {24} | {25} | {26} | {27} | {28} | {29} |
=========================
f| {30} | {31} | {32} | {33} | {34} | {35} |
=========================
", printableArray);
            string board8 = string.Format(
@"   A   B   C   D   E   F   G   H
=================================
a| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |
=================================
b| {8} | {9} | {10} | {11} | {12} | {13} | {14} | {15} |
=================================
c| {16} | {17} | {18} | {19} | {20} | {21} | {22} | {23} |
=================================
d| {24} | {25} | {26} | {27} | {28} | {29} | {30} | {31} |
=================================
e| {32} | {33} | {34} | {35} | {36} | {37} | {38} | {39} |
=================================
f| {40} | {41} | {42} | {43} | {44} | {45} | {46} | {47} |
=================================
g| {48} | {49} | {50} | {51} | {52} | {53} | {54} | {55} |
=================================
h| {56} | {57} | {58} | {59} | {60} | {61} | {62} | {63} |
=================================
", printableArray);
            string board10 = string.Format(
@"   A   B   C   D   E   F   G   H   I   J
==========================================
a| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} |
==========================================
b| {10} | {11} | {12} | {13} | {14} | {15} | {16} | {17} | {18} | {19} |
==========================================
c| {20} | {21} | {22} | {23} | {24} | {25} | {26} | {27} | {28} | {29} |
==========================================
d| {30} | {31} | {32} | {33} | {34} | {35} | {36} | {37} | {38} | {39} |
==========================================
e| {40} | {41} | {42} | {43} | {44} | {45} | {46} | {47} | {48} | {49} |
==========================================
f| {50} | {51} | {52} | {53} | {54} | {55} | {56} | {57} | {58} | {59} |
==========================================
g| {60} | {61} | {62} | {63} | {64} | {65} | {66} | {67} | {68} | {69} |
==========================================
h| {70} | {71} | {72} | {73} | {74} | {75} | {76} | {77} | {78} | {79} |
==========================================
i| {80} | {81} | {82} | {83} | {84} | {85} | {86} | {87} | {88} | {89} |
==========================================
j| {90} | {91} | {92} | {93} | {94} | {95} | {96} | {97} | {98} | {99} |
==========================================
", printableArray);

            switch (m_messages.BoardSize)
            {
                case 6:
                    Console.WriteLine(board6);
                    break;
                case 8:
                    Console.WriteLine(board8);
                    break;
                case 10:
                    Console.WriteLine(board10);
                    break;
            }
            //Console.WriteLine(board6);
        }
        public object[] createPrintableArray()
        {
           // object[] o_printableArray = new object[m_messages.BoardSize * m_messages.BoardSize];
            object[] o_printableArray = new object[10*10]; // need to define MAX
            for (int i = 0; i < m_messages.BoardSize; i++)
            {
                for (int j = 0; j < m_messages.BoardSize; j++)
                {
                    o_printableArray[i* m_messages.BoardSize + j] = m_game.currentState.boardArray[i,j].getShape();
                }
            }
            return o_printableArray;
        }
        private void getUserMove()
        {
            m_currentMove = Console.ReadLine();
            if (!isUserMoveValid(m_currentMove))
            {
                while (!isUserMoveValid(m_currentMove))
                {
                    Screen.Clear();
                    printBoard();
                    System.Console.SetCursorPosition(0, m_messages.BoardSize+2);
                    m_messages.printInvalidInput();
                    m_currentMove = Console.ReadLine();
                }
            }
        }
        private bool isUserMoveValid(string move) //Not finished!!
        {
            // string
            if (m_currentMove.Length != 5)
            {
                Console.WriteLine("NO");
                return false;
            }
            else
            {
                Console.WriteLine("YES");
                return true;
            }
        }
    }
}



