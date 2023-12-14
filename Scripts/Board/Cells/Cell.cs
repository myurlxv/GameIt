// CustomCell.cs ����
using UnityEngine;

namespace Ninez.Board
{
    public class CustomCell
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
                m_CellBehaviour.SetCustomCell(this);
            }
        }

        // ������ �̸� ����
        public CustomCell(CellType cellType)
        {
            m_CellType = cellType;
        }

        // �ٸ� �ڵ� ����...

        // �޼��� �̸� ����
        public CustomCell InstantiateCellObject(GameObject cellPrefab, Transform containerObj)
        {
            //1. Cell ������Ʈ�� �����Ѵ�.
            GameObject newObj = Object.Instantiate(cellPrefab, new Vector3(0, 0, 0), Quaternion.identity);

            //2. �����̳�(Board)�� ���ϵ�� Cell�� ���Խ�Ų��.
            newObj.transform.parent = containerObj;

            //3. Cell ������Ʈ�� ����� CellBehaviour ������Ʈ�� �����Ѵ�.
            this.cellBehaviour = newObj.transform.GetComponent<CellBehaviour>();

            return this;
        }

        // �ٸ� �ڵ� ����...

        // �޼��� �̸� ����
        public void Move(float x, float y)
        {
            if (cellBehaviour != null)
            {
                cellBehaviour.transform.position = new Vector3(x, y);
            }
            else
            {
                Debug.LogWarning("CellBehaviour is not set. Move operation ignored.");
            }
        }
    }
}
