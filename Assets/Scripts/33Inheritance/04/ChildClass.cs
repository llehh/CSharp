using UnityEngine;

namespace InheritanceProtectedTest
{
    //�ڽ�Ŭ���� ����
    public class ChildClass : ParentClass // :(�ݷ�) ��ȣ�� �θ�Ŭ���� ����
    {
        public void PrintMessage2()
        {
            //�ڽ� Ŭ���� �ڵ� ��� �ȿ��� �θ��� ����� ���� ��� : base Ű���� ���
            base.PrintMessage();
            Debug.Log("�ڽ�Ŭ�������� ������ ����");
        }
    }
}

