using UnityEngine;

namespace Method
{
    public class ParameterIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //������ ���� num �����ϰ� �ʱ�ȭ
            int num = 10;
            Debug.Log($"[1]: {num}");   //10

            PrintNumber(num);

            Debug.Log($"[3]: {num}");       //10

        }

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]: {num}");       //20
        }

    }

}
/*
�Ű�����(Parameter) 
: ���޵Ǵ� ����� ���� ����
[1] �� ���� ���        (int num)
[2] ���� ���� ���      (ref int num)
[3] ��ȯ�� ���� ���    (out int num)
[4] ������ ���� ���    (params int[] numbers)
*/