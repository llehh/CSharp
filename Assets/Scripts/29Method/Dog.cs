using UnityEngine;

namespace Method
{
    public class Dog
    {
        //�ʵ� �����, ��������, �������
        public static int point = 10;
        private int weigth = 20;

        //�ν��Ͻ�(instance) �޼���, �Լ�, ����Լ�
        public void Eat()
        {
            Debug.Log("[1] ���� �Դ´�");

            Digest();
        }

        private void Digest()
        {
            Debug.Log("[2] ��ȭ�� ��Ų��");
        }

        //����(static) �޼���
        public static void Drink()
        {
            Debug.Log("[3] ���� ���Ŵ�");
        }

    }

}
