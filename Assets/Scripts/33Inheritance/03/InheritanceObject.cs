using InheritanceObjectTest;
using UnityEngine;

namespace Inheritance
{
    public class InheritanceObject : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�θ�Ŭ������ �ν��Ͻ�(��ü) ���� 
            Parent pa = new Parent();
            //pa.Hi();
            Debug.Log(pa.ToString());

            //�ڽ� Ŭ������ �ν��Ͻ�(��ü) ����
            Child ch = new Child();
            Debug.Log(ch.ToString());

            //static �޼��� : (Ŭ�����̸�).(�޼����̸�)
            Parent.Hi();
           
            Child.Hi();
            Child.Hello();

        }
    }
}
