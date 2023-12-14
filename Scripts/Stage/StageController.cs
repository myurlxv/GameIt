// StageController.cs ����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ninez.Stage;
using Ninez.Board; // ����: Board ���ӽ����̽� �߰�

namespace Ninez.Stage
{
    public class Block
    {
        private BlockType m_BlockType;

        public Block(BlockType blockType)
        {
            m_BlockType = blockType;
        }
    }

    public class StageController : MonoBehaviour
    {
        [SerializeField] Transform m_Container;
        [SerializeField] GameObject m_CellPrefab;
        [SerializeField] GameObject m_BlockPrefab;

        private Ninez.Board.Board m_Board; // ����: Stage�� ���� ����ϴ� ��ſ� Board�� ���

        void Start()
        {
            BuildStage();
        }

        void BuildStage()
        {
            // 1. Board�� �����Ѵ�.
            m_Board = new Ninez.Board.Board(9, 9);

            // 2. ������ Board ������ �̿��Ͽ� ���� �����Ѵ�.
            m_Board.ComposeStage(m_CellPrefab, m_BlockPrefab, m_Container);
        }
    }
}
