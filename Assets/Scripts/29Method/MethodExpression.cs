using UnityEngine;

namespace Method
{
    //�޼��� �����, ȭ��ǥ �Լ�
    public class MethodExpression : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();

            Debug.Log(DoubleValue(4));      //8
            Debug.Log(Sum(3,5));            //8
        }

        //�Լ� �⺻����
        void Work()
        {
            Debug.Log("Work!!!");
        }

        //�����
        //Hello ����ϴ� �޼���
        void Hello() => Debug.Log("Hello");

        //�Ű������� �Է� ���� �������� �ι�� ��ȯ�ϴ� �޼��� 
        int DoubleValue(int value) => value * 2;

        //�Ű������� �Է� ���� �� ���� ������ ���� ���� ��ȯ�ϴ� �޼���
        int Sum(int a, int b) => a + b;
    }

}
