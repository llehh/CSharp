using UnityEngine;

namespace Method
{
    //[4] ������ ���� ��� (params int[] numbers)
    public class ParameterParams : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(SumAll(3, 4));
            Debug.Log(SumAll(3, 5, 7));
            Debug.Log(SumAll(3, 5, 7, 9));
        }

        //�Ű������� ���� �������� ���� ���ϴ� �޼��� - SumAll
        private int SumAll(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            return sum;

        }

    }
}