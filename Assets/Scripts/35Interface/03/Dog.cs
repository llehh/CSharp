using UnityEngine;

namespace InterfaceDemoTest
{
    //�������� �����ϴ� Ŭ����
    //�������̽��� ���� ����� ����, Ŭ������ ���� ����� �Ұ��� 
    public class Dog : IAnimal, IDog
    {
        //IAnimal �������̽� ��� ����
        public void Eat()
        {
            Debug.Log("�Դ�");
        }

        //IDog �������̽� ��� ����
        public void Yelp()
        {
            Debug.Log("¢��");
        }
    }
}
