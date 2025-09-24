using UnityEngine;

namespace Method
{
    //[2]���� ���� ��� (ref int num)
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1]: {number}");     //[1]: 10
            
            PrintNumber(ref number);

            Debug.Log($"[3]: {number}");    //[3]: 20
        }

        //������ ���� num��  ref �Ű������� �Է� �޾� ����ϴ� �޼���
        void PrintNumber(ref int number)
        {
            number = 20;
            Debug.Log($"[2]: {number}");    //[2]: 20
        }

    }

}