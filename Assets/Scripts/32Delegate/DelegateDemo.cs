using UnityEngine;

namespace Delegate
{
    public class DelegateDemo : MonoBehaviour
    {
        //[1]��������Ʈ ����, ���� - Hi()�� ��� ���� �븮��
        //��ȯ���� ����, �Ű������� ����
        //delegate ��ȯ�� �븮���̸� (�Ű�����)
        delegate void SayDelegate();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Hi();   //"�ȳ��ϼ���"

            //[2]�븮�� ���� ���� �� ����� �޼��� ���1 
            SayDelegate say= Hi;

            //[3] ��������Ʈ ����(ȣ��)
            say();  //"�ȳ��ϼ���"

            //[4] �븮�� ���� ���� �� ����� �޼��� ���2
            SayDelegate hello = new SayDelegate(Hello);
            //��������Ʈ ����(ȣ��)1
            hello();        //"Hello"

            //�븮�� ���� ���� �� ����� �޼��� ���3.
            SayDelegate insa = new SayDelegate(Hi);
            //��������Ʈ ����(ȣ��)2
            insa.Invoke();   //"�ȳ��ϼ���"

        }

        //�޼��� 
        void Hi()
        {
            Debug.Log("�ȳ��ϼ���");
        }

        void Hello()
        {
            Debug.Log("Hello");
        }

    }
}
/*
Ŭ���� ���
: �ʵ�(��������, �������), ������(�Ҹ���), �޼���(�Լ�, ����Լ�)
: �Ӽ�(������Ƽ), �ε���(�ݺ���), ��������Ʈ(�븮��)

Delegate(�븮��): �Ű����� ��� �� ��ȯ ������ �ִ� �޼��忡 ���� ������ ��Ÿ���� ����
               : ��� ����(�����ִ�)��, ���(����)�� �޼���(��)�� ��� ��������ִ� ��

//���� - ��ȯ���� ����, �Ű����� ���� �Լ��� ��� ��������ִ� ��
delegate void �븮���̸� () 

//������ ��������Ʈ�� �޼��带 ��� - ����� ���(�븮�� ����)�� ����� ���
�븮�� �̸� �븮�� ����

��������Ʈ ����(����) -> ������ ��������Ʈ�� �޼��带 ��� -> ��������Ʈ ����
*/
