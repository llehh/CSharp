using UnityEngine;

namespace InterfaceDemoTest
{
    public class InterfaceInheritance : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog Ŭ���� �ν��Ͻ� ����
            Dog dog = new Dog();
            dog.Eat();  //IAnimal �������̽� ��� ���� �� ȣ��
            dog.Yelp(); //IDog �������̽� ��� ���� �� ȣ��
        }
    }
}
