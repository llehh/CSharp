using UnityEngine;
using InheritanceProtectedTest;

namespace Inheritance
{
    public class InheritanceProtected : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]�θ�Ŭ���� �ν��Ͻ� ����
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();    //protected (��ȣ���� ����) ���� �Ұ�
            Debug.Log(parent.ToString());

            //[2]�ڽ�Ŭ���� �ν��Ͻ� ����
            ChildClass child = new ChildClass();
            //child.PrintMessage();   //protected (��ȣ���� ����) ���� �Ұ�
            child.PrintMessage2();

        }


    }
}

/*
-public : ������ ������ ����
-private : �ش�(����) Ŭ�����ȿ����� wjqrmsdl rksmdgkek
-Protected : 
*/