using InheritanceConstructorTest;
using UnityEngine;

namespace Inheritance
{
    public class InheritanceContructor : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ڽ� Ŭ������ �ν��Ͻ�(��ü) ����
            Child child = new Child();
            child.SayHello();   //�ȳ��ϼ��� �λ�

            Child child2 = new Child("�ݰ����ϴ�");
            child2.SayHello();  //
        }

    }
}
