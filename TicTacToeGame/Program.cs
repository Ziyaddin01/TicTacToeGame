using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public enum State
    {
        Cross,
        Zero,
        Unset
    }
    public class TicTacToeGame
    {
        private readonly State[] board = new State[9];
        public int MovesCounter { get; private set; }

        public TicTacToeGame()
        {
            for(int i=0; i<board.Length; i++)
            {
                board[i] = State.Unset;
            }
        }

        public void MakeMove(int index)
        {
            board[index - 1] = MovesCounter % 2 == 0 ? State.Cross : State.Zero;

            MovesCounter++;
        }

        public State GetState(int index)
        {
            return board[index - 1];
        }
    }
}
