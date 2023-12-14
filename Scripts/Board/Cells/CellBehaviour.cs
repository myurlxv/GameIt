// CellBehaviour.cs ����
using UnityEngine;

namespace Ninez.Board
{
    public class CellBehaviour : MonoBehaviour
    {
        CustomCell m_CustomCell;
        SpriteRenderer m_SpriteRenderer;

        void Start()
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();
            // UpdateView �޼��带 Start���� ȣ������ �ʵ��� ����
        }

        public void SetCustomCell(CustomCell customCell)
        {
            m_CustomCell = customCell;
            UpdateView(false); // m_CustomCell�� ������ �Ŀ� UpdateView�� ȣ��
        }

        public void UpdateView(bool bValueChanged)
        {
            if (m_CustomCell != null && m_CustomCell.type == CellType.EMPTY)
            {
                m_SpriteRenderer.sprite = null;
            }
            // Add additional conditions or actions based on the CustomCell's properties
        }
    }
}
