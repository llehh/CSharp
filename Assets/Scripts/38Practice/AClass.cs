using UnityEngine;

namespace Practice
{
    public class AClass
    {
        //�ʵ�(�������, ��������) �����
        //string �迭, �ʱⰪ
        private string[] weekDays = { "��", "��", "ȭ", "��", "��", "��", "��", "��" };

        //�ν��Ͻ� ��� �Լ� �����
        //�ʵ忡�� ����� �迭 ���� ����ϱ�
        public void PrintWeekDays()
        {
            foreach (string day in weekDays)
            { 
                Debug.Log(day);
            }
        }

        //����(static) ��� �Լ� �����
        //�ΰ��� ������ �Ű������� �Է¹޾� �� ���� ���� �� ��� ���� ��ȯ�ϱ�
        public static int Sum(int x, int y)
        { 
            return x + y; 
        }
        
    }


    public class Bclass : MonoBehaviour
    { 
        
    }
}

/*
[Q]
1) AClass Ŭ���� �����
2) �ʵ�(�������, ��������) �����
: string �迭, �ʱⰪ{ ��, ��, ȭ, ��, ��, ��, �� }
3) �ν��Ͻ� ��� �Լ� �����
:�ʵ忡�� ����� �迭���� ����ϱ�
4) ����(static) ��� �Լ� �����
: �ΰ��� ������ �Ű������� �Է¹޾� �� ���� ���� �� ��� ���� ��ȯ�ϱ�

1) Monobehaviour Ŭ������ ��ӹ޴� BClass �����
2) AClass�� �ν��Ͻ� ��� �Լ� ȣ���ϱ�
3) AClass�� ����(static) ��� �Լ� ȣ���ؼ� ��ȯ���� �� ����ϱ�
: �Ű����� (5, 6)

[output]
��
��
ȭ
��
��
��
��
11
*/