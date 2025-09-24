using UnityEngine;
using System.Linq;

namespace Practice
{
    public class Min : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� ���� �� �ʱ�ȭ
            int[] numbers = { -2, -5, -4, -7, -1 };

            //�ּҰ��� �����ϴ� ����
            //�ּҰ� �ʱ�ȭ�� ���� ū������ �ʱ�ȭ
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                //�ּҰ��� �迭�� ���� ������� ũ�� ��
                if (numbers[i] < minValue)
                { 
                    minValue = numbers[i];  //�μ��� ���Ͽ� ������ �ּҰ��� ����
                }
            }

            Debug.Log($"�ּҰ��� {minValue}");

            int minimumValue = numbers.Min();
            Debug.Log($"Linq �ּҰ��� {minValue}");

        }
    }
}

/*
������ { -2, -5, -4, -7, -1 }
�Էµ� �������� �ּҰ��� ���ϼ���

[output]
�ּҰ��� -7

// -2, -5, -4, -7, -1

minValue(�ּҰ�) -2 => minValue = -2
-2(minValue)  -5  => minValue = -5
-5(minValue)  -4  
-5(minValue)  -7
-7(minValue)  -1  => minValue = -7
-7(minValue)
*/
