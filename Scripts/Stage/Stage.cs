// Stage.cs ����

using UnityEngine;
using Ninez.Board;

namespace Ninez.Stage
{
    public class Stage
    {
        private Ninez.Board.Board m_Board;

        public Block[,] blocks { get; set; }
        public CustomCell[,] cells { get; set; }

        public int maxRow { get; private set; } // ����: maxRow ����
        public int maxCol { get; private set; } // ����: maxCol ����

        // �ٸ� �ڵ� ����...

        // Stage ������
        public Stage(int row, int col)
        {
            maxRow = row;
            maxCol = col;

            // 'blocks' �� 'cells' �迭 �ʱ�ȭ
            blocks = new Block[row, col];
            cells = new CustomCell[row, col];

            m_Board = new Ninez.Board.Board(row, col);
        }

        // �ٸ� �ڵ� ����...

    }
}
