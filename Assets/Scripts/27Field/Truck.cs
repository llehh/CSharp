using UnityEngine;

namespace Field
{
    public class Truck
    {
        //�ʵ� ����
        //����(static) ��� ���� ���� �� �ʱ�ȭ
        public static string name = "Ʈ��";
        //�ν��Ͻ�(instance) ��� ���� ����
        private int age;

        //����(static) ��� �Լ�, �޼��� : �ν��Ͻ� ����� �ٷ� ������� ���Ѵ�
        public static string GetName()
        {
            return name;
        }

        //�ν��Ͻ�(instance)��� �Լ�, �޼��� 
        public void SetAge(int value)
        { 
            age = value;
        }

        public int GetAge()
        { 
            return age;
        }

    }

}
