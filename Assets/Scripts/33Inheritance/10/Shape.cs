using UnityEngine;

namespace AbstractNoteTest
{
    //������ �����ϴ� �߻� Ŭ����
    //�������� ����(�ﰢ��, �簢��, ��, ....)���� �θ� Ŭ���� 
    //������ ������ ���ϴ� �޼��� - ������ �����ϵ��� �Ѵ� (�߻� �޼���) 
    public abstract class Shape
    {
        //�߻�޼���
        public abstract double GetArea();
    }
}
