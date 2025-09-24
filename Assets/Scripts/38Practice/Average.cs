using UnityEngine;

namespace Practice
{
    public class Average : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //����� ���϶�
            //��� = ���� / (������ ����)����

            //���� ���� �� �ʱ�ȭ
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int total = 0;
            int count = 0;
            double avg = 0;

            //����, ���� ���ϱ�
            for (int i = 0; i < scores.Length; i++)
            {
                //70�� �̻��̰� 95�� ������ �������� ����
                if (scores[i] >= 70 && scores[i] <= 95)
                {
                    total += scores[i];
                    count++;
                }
            }

            //��� ���ϱ� 
            if (count > 0)
            {
                avg = total / (double)count;
            }

            Debug.Log($"70�� �̻��̰� 95�� ������ �������� ���: {avg:0.00}");
            
        }
    }
}

/*
[Q]
������ { 100, 75, 50, 37, 90, 95 }
���� ���� �� 70�� �̻��̰� 95�� ������ �������� ����� ���϶�

[output]
70�� �̻��̰� 95�� ������ �������� ��� : ?
*/