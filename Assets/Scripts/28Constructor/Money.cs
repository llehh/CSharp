using UnityEngine;

namespace Constructor
{
    public class Money
    {
        //�⺻ ������
        public Money() : this(1000)  //�Ű������� �ִ� ������ ����(������)
        {
            Debug.Log("�⺻ ������ ����");
        }

        //�Ű������� �ִ� ������ - �Ű������� ���� ��带 �ʱ� ���������� ����
        public Money(int gold)
        {
            Debug.Log($"�ʱ� ������ {gold:#,###}��带 ���� �߽��ϴ�");
        }
    }

}