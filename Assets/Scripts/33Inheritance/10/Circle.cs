using UnityEngine;

namespace AbstractNoteTest
{
    //Shape(�߻� Ŭ����)�� ��ӹ޴� ���� �����ϴ� �ڽ�Ŭ���� 
    //Shape�� �����ϴ� �߻�޼���(GetArea())�� �����ؾ��Ѵ�
    public class Circle : Shape
    {
        //�ʵ�
        private int size;  //������ 

        //������ - �Ű������� �Է¹޾� �ʵ�(size) �ʱ�ȭ
        public Circle(int _size)
        { 
            this.size = _size;
        }


        //�߻� �޼��� ����
        public override double GetArea()
        {
            //������ x ������ x 3.14
            return size * size * 3.14;
        }
    }
}
