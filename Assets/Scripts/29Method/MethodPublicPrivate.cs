using UnityEngine;

namespace Method
{
    public class MethodPublicPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog Ŭ���� �ν��Ͻ�(��ü) ����
            Dog cat = new Dog();

            //�ν��Ͻ� �޼��� �����
            //�ν��Ͻ��̸�.(public)�Լ��̸� ���� ȣ��
            cat.Eat();     //public �޼��� ���(ȣ��) ����
            //cat.Digest();  //private �޼��� ��� �Ұ��� (��ȣ���� ������)
             
            //����(static) �Լ���  ��� ���
            //Ŭ�����̸�.�����Լ��̸� �̸����� ȣ��
            Dog.Drink();
        }


    }

}
