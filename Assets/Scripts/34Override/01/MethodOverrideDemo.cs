using UnityEngine;
using OverrideDemoTest;

namespace MethodOverride
{
    //MethodOverride(�޼��� ������)
    //�θ� Ŭ������ �޼��带 ������(�ٽ� ����, ����)�ؼ� ����ϱ�
    public class MethodOverrideDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ڽ� Ŭ���� �ν��Ͻ� ����
            Child child = new Child();

            child.Say();    //[1] �׳� ���
            child.Run();    //[2] new
            child.Walk();   //[3] vitual -> override
        }

    }
}
