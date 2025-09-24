using UnityEngine;
using InheritanceDemoTest;

namespace Inheritance
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ڽ�(Child) Ŭ������ �ν��Ͻ� ����
            Child child = new Child();

            //�ڽ� Ŭ������ ��� �޼��� ȣ��
            child.Bar();

            //�θ� Ŭ������ ��� �޼��� ȣ��
            child.Foo();
            //
        }

    }
}

/*
Inheritance(���) 
: �θ�Ŭ������ �ڽ��� ��� ���� �ڽ� Ŭ�������� �����־ ����ϵ��� ���ش�

�θ�Ŭ���� : ����Ŭ����, Base(���̽�)Ŭ����, �⺻ Ŭ����  
: �θ�� �ڽ� Ŭ������ ������ ���� �� �ִ� 
: �ڽ� Ŭ�������� ���� ����� ��� ���� Ŭ������ �θ� Ŭ����

�ڽ�Ŭ���� : Sub(����) Ŭ���� 
//�ڽ� Ŭ���� ����: �ڽ� Ŭ������ �θ�Ŭ������ �����ϸ� �θ�Ŭ������ ����� ��� ����� �� �ִ� 
public class �ڽ�Ŭ�����̸� : �θ�Ŭ���� �̸�
 
����Ŭ���� : �ڽ� Ŭ������ �ڽ� Ŭ����
: �θ� Ŭ������ �ڽ� Ŭ������ ��� ����� �����޴´�
*/
