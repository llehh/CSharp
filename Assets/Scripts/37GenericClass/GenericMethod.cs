using UnityEngine;

namespace Generic
{
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello<T> ���׸� Ŭ���� �ν��Ͻ� ����
            Hello<int> hi = new Hello<int>();
            Debug.Log(hi.GetMessage());
            hi.Say(1234);

            Hello<string> hello = new Hello<string>("�ȳ��ϼ���");
            Debug.Log(hello.GetMessage());
            hello.Say("�ݰ����ϴ�");
        }

    }
}
