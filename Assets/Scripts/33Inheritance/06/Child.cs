using UnityEngine;

namespace InheritanceConstructorTest
{
    //�ڽ� Ŭ���� ����
    public class Child : Parent
    {
        //������
        public Child() : this("�ȳ��ϼ���")
        {
            Debug.Log("�ڽ��� �⺻ ������ ����");
        }

        public Child(string message) : base(message)
        { 
            
        }

        //�޼���
        public void SayHello()
        {
            Debug.Log(base.Word);
        }

    }
}
