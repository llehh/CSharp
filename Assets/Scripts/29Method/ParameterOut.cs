using UnityEngine;

namespace Method
{
    //[3] ��ȯ�� ���� ��� (out int num)

    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //������ ���� ����, �ݵ�� �ʱ�ȭ �� �ʿ�� ����
            int number;

            PrintNumber(out number);

            Debug.Log($"[2]: {number}");    //[2]: 20

        }

        //������ ������ number�� out�Ű������� �Է� �޾� ����ϴ� �޼���
        //ref (���� ���� ���)�� ����
        //�Լ� ���ο��� �ݵ�� �ʱ�ȭ(�� ����) �ؾ� �Ѵ�
        void PrintNumber(out int number)
        {
            number = 20;
            Debug.Log($"[1]: {number}");        //[1]: 20
        }

    }

}
