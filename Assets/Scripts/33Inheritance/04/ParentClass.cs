using UnityEngine;

namespace InheritanceProtectedTest
{
    //�θ� Ŭ����
    public class ParentClass : System.Object //��� Ķ���� Object Ŭ�����κ��� ��� �޴´�
    {
        //�θ� Ŭ���� �ڵ� ��� �ȿ����� private �� ���� ����� �Ѵ�
        //protected ��� ���� �ڽ�Ŭ����(�ڵ� ��� ��)������ ���� ����
        protected void PrintMessage()
        {
            Debug.Log("�θ�Ŭ�������� (protected)������ ����");
        }
    }
}
