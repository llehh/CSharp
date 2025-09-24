using UnityEngine;

namespace Constructor
{
    public class ContructorToDestructor : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //DestructorTest Ŭ���� �ν��Ͻ� ����
            DestructerTest test = new DestructerTest();

            //���
            test.Run();

            //�Ҹ�: �������÷���(GC)�� �˾Ƽ� �Ѵ�
            //~DestructerTest();
        }


    }

}


/*
Destructor(�Ҹ���):
: Ŭ������ ���� �� ���� �������� ȣ��Ǵ� �޼���
: ������ �ν��Ͻ�(��ü)�� �޸𸮻󿡼� �������� ȣ��
: �̶� Ŭ�������� ���� ��� �޸� ���� ���� ó��
C# �޸� ���� : GC(������ �÷���)�� �޸� ���� ������ ��� �Ѵ�

�Ҹ��� ����

class Car
{
    //�Ҹ���
    ~Car()
    {
        //��ü�� �Ҹ��Ҷ� �ʿ��� ��� ����
    }
}

 
*/
