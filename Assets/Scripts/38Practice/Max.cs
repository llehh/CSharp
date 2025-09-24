using UnityEngine;

namespace Practice
{
    public class Max : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� ���� �� �ʱ�ȭ
            int[] numbers = { -2, -5, -4, -7, -1 };

            //�ִ밪�� ���ϴ� ����
            //������ Ÿ���� ���� ���������� �ʱ�ȭ
            int maxValue = int.MinValue;

            //�ִ밪 ���ϱ�
            for (int i = 0; i < numbers.Length; i++)
            {
                //�ִ밪�� �迭�� ���� ������� ũ�� ��
                if (numbers[i] > maxValue)
                { 
                    maxValue = numbers[i];  //�μ��� ũ�⸦ ���Ͽ� ũ�� maxValue�� ����
                }
            }
            Debug.Log($"�ִ밪�� {maxValue}");
        }
               

       
    }
}

/*
������ { -2, -5, -4, -7, -1 }
�Էµ� �������� �ִ밪�� ���ϼ���

[output]
�ִ밪�� -1

// -2, -5, -4, -7, -1
 
maxValue -2 => maxValue = -2
*/
