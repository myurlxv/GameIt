namespace Ninez.Board
{
    public enum CellType
    {
        EMPTY = 0,      //�����, ���� ��ġ�� �� ����, ��� ���
        BASIC = 1,      //����ִ� �⺻ �� (No action)
        FIXTURE = 2,    //������ ��ֹ�. ��ȭ����
        JELLY = 3,      //���� : �� �̵� OK, �� CLEAR�Ǹ� BASIC, ��� : CellBg
    }
}
