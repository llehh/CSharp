using UnityEngine;

namespace Method
{
    //������ �Ű�����
    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(3, 5));  //3 + 5 = 8
            Debug.Log(Add(3));     //3 + 1 = 4
        }

        //������ �Ű�����
        //�Ű������� ���� �ΰ��� ������ ���� ��ȯ�ϴ� �Լ�
        //�Լ� ȣ��� �Ű����� b���� ���������ϴ�, �����ϸ� b���� 1�� ����ȴ�
        int Add(int a, int b = 1)
        { 
            return a + b;   
        }
        
    }
}
