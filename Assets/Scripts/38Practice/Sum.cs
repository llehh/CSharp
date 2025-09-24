using UnityEngine;

namespace Practice
{
    public class Sum : MonoBehaviour
    {
         
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� ���� �� �ʱ�ȭ
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int total = 0;

            //���� ���ϱ�
            for (int i = 0; i < scores.Length; i++)
            {
                //70�� �̻��� �������� ������ ���϶�
                if (scores[i] >= 70)
                {
                    total += scores[i];
                }
            }

            //���
            Debug.Log($"70�� �̻��� ������ ����: {total}");
            
        }

    }
}

/*
[Q]
������ { 100, 75, 50, 37, 90, 95 }
���� ���� �� 70�� �̻��� �������� ������ ���϶�

[output]
70�� �̻��� ������ ����: 360
 
*/
