using UnityEngine;


namespace MethodOverride
{
    public class MethodOverrideNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�θ� Ŭ������ �ν��Ͻ� ����
            Animal animal = new Animal();
            animal.Eat();

            //�ڽ� Ŭ������ �ν��Ͻ� ����
            Dog dog = new Dog();
            dog.Eat();

            //�θ� Ŭ������ ��ü�� �ڽ� �ν��Ͻ��� ����
            Animal happy = new Dog();
            happy.Eat();
        }


    }
}
