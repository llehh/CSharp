using UnityEngine;

namespace Constructor
{
    public class ConstructorForword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Money Ŭ������ �ν��Ͻ�(��ü) ����
            Money basic = new Money();   //�⺻ ������ ȣ��
            Money bonus = new Money(2000);  //�Ű������� �ִ� ������ ȣ�� 

            //WithServiece Ŭ������ �ν��Ͻ� ����
            WithService file = new WithService();
            file.Run();

            WithService db = new WithService("DB �α�");
            db.Run();

        }

    }

}
