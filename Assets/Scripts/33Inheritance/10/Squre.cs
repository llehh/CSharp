using UnityEngine;

namespace AbstractNoteTest
{
    //Shape(�߻� Ŭ����)�� ��ӹ޴� ���簢���� �����ϴ� �ڽ�Ŭ���� 
    //Shape�� �����ϴ� �߻�޼���(GetArea())�� �����ؾ��Ѵ�
    public class Squre : Shape
    {
        //�ʵ� 
        private int size;   //����,���� ����

        //������ - �Ű������� �Է¹޾� �ʵ� �ʱ�ȭ
        public Squre(int _size)
        { 
            this.size = _size;
        }

        //�߻�޼��� ����
        public override double GetArea()
        {
            return size * size;
        }
    }
}
