using UnityEngine;

namespace Oop
{
    //[1]�߻�Ŭ����:
    public abstract class Animal
    {
        //�߻�޼���
        public abstract string Cry();
    }

    //[2] Dog Ŭ����
    public class Dog : Animal
    {
        public override string Cry() => "�۸۸�";
        
    }

    //[3]����� Ŭ����
    public class Cat : Animal
    {
        public override string Cry() => "�߿�";
        
    }

    //[4] Ʈ���̳� Ŭ����
    public class Trainer
    {
        //�Ű������� �Է¹��� ������ ��� �Ѵ�
        public void Docry(Animal animal) 
        {
            //animal? Dog, Cat
            Debug.Log(animal.Cry());
        }

      /*  public void Docry(Dog dog)
        {
            
            Debug.Log(dog.Cry());
        }


        public void Docry(Cat cat)
        {
            
            Debug.Log(cat.Cry());
        }*/



    }

    public class OopNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] �⺻ Ŭ���� �ν��Ͻ� ����
            Dog dog = new Dog();
            Debug.Log(dog.Cry());

            Cat cat = new Cat();
            Debug.Log(cat.Cry());

            //[2] �θ� Ŭ������ �̸����� �ڽ�Ŭ������ �ν��Ͻ� ���� - ��ĳ����
            Animal myDog = new Dog();
            Debug.Log(myDog.Cry());

            Animal myCat = new Cat();
            Debug.Log(myCat.Cry());

            //[3]������
            //animal.Cry() �޼��带 ȣ���Ѵ�
            //�Է¹��� �Ű������� ���� ���� �ٸ� ������ ����� ����ȴ�
            //�������� �޼��� �������̵��� ���ؼ� �����ȴ�
            Trainer trainer = new Trainer();
            trainer.Docry(dog);
            trainer.Docry(cat);


        }


    }
}
/*
������ : ���
: ��ü(��ü)�� �������� �������� ���� �� �ִ�
: ��ü(��ü) �������� ���·� ������ �ִ�
: ���ĺ�ȯ
��ĳ����: �ڽ� Ŭ������ �ν��Ͻ��� �θ� Ŭ���� �������� �д°�
�ٿ�ĳ����: �θ� Ŭ������ �ν��Ͻ��� �ڽ� Ŭ������ �������� �д°�
*/