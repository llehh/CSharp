using UnityEngine;

namespace MethodOverride
{
    public class MethodOverrideOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�޼��� Overloading
            Hi();
            Hi("�ݰ����ϴ�");
            Hi("�� ������", 3);

            //�޼��� Override
            //�θ� Ŭ���� Hi()
            ParentClass parent = new ParentClass();
            parent.Hi();

            //�ڽ� Ŭ���� Hi()
            ChildClass child = new ChildClass();
            child.Hi();

        }


        //�޼��� Overloading
        public void Hi()
        {
            Debug.Log("�ȳ��ϼ���");
        }

        public void Hi(string message)
        { 
            Debug.Log(message);
        }

        public void Hi(string msg, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Debug.Log(msg);
            }
        }
    }
}