using UnityEngine;

namespace Constructor
{
    public class ConstructorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person Ŭ������ �ν��Ͻ� ����
            //[1]�Ű������� ���� �⺻ ������ ȣ��
            Person saram1 = new Person();
            Debug.Log(saram1.GetName());

            //�ٸ� ���2 saram2
            Person saram2 = new Person();
            Debug.Log(saram2.GetName());

            //[2]�Ű� ������ �ִ� ������ ȣ��
            Person person1 = new Person("��λ�");
            Debug.Log(person1.GetName());

            //�ٸ� �۽�, person2 
            Person person2 = new Person("����");
            Debug.Log(person2.GetName());

        }


    }

}