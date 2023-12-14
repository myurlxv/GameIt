// StageBuilder.cs ����

using UnityEngine;

namespace Ninez.Stage
{
    // Enums.cs ���Ͽ� ���ǵ� ���ӽ����̽��� ���� ���ӽ����̽� ���
    public class Cell
    {
        protected CellType m_CellType;
        public CellType type
        {
            get { return m_CellType; }
            set { m_CellType = value; }
        }

        protected CellBehaviour m_CellBehaviour;
        public CellBehaviour cellBehaviour
        {
            get { return m_CellBehaviour; }
            set
            {
                m_CellBehaviour = value;
                m_CellBehaviour.SetCell(this);
            }
        }

        public Cell(CellType cellType)
        {
            m_CellType = cellType;
        }

        public Cell InstantiateCellObj(GameObject cellPrefab, Transform containerObj)
        {
            //1. Cell ������Ʈ�� �����Ѵ�.
            GameObject newObj = Object.Instantiate(cellPrefab, new Vector3(0, 0, 0), Quaternion.identity);

            //2. �����̳�(Board)�� ���ϵ�� Cell�� ���Խ�Ų��.
            newObj.transform.parent = containerObj;

            //3. Cell ������Ʈ�� ����� CellBehaviour ������Ʈ�� �����Ѵ�.
            this.cellBehaviour = newObj.transform.GetComponent<CellBehaviour>();

            return this;
        }

        public void Move(float x, float y)
        {
            cellBehaviour.transform.position = new Vector3(x, y);
        }
    }

    public class CellBehaviour : MonoBehaviour
    {
        Cell m_Cell;
        SpriteRenderer m_SpriteRenderer;

        void Start()
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();

            UpdateView(false);
        }

        public void SetCell(Cell cell)
        {
            m_Cell = cell;
        }

        public void UpdateView(bool bValueChanged)
        {
            if (m_Cell.type == CellType.EMPTY)
            {
                m_SpriteRenderer.sprite = null;
            }
        }
    }

    public static class StageBuilder
    {
        public class Stage
        {
            // Stage Ŭ���� ������ �ʿ信 ���� �߰�
        }

        public static Stage BuildStage(int nStage, int row, int col)
        {
            // ���⿡ Stage�� �����ϴ� �ڵ带 �߰��ϼ���.
            // ���� ���, Stage Ŭ������ �ν��Ͻ��� �����ϰ� ��ȯ�� �� �ֽ��ϴ�.
            return new Stage(); // ���÷� �� Stage Ŭ������ �ν��Ͻ��� ��ȯ�ϵ��� ����
        }
    }
}
