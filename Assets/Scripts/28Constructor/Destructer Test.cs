using UnityEngine;

namespace Constructor
{
    public class DestructerTest
    {
        //������
        public DestructerTest() 
        {
            Debug.Log("[1] ����");        
        }

        //��� - �޼���
        public void Run()
        {
            Debug.Log("[2] ����");
        }

        //�Ҹ���: GC�� ȣ��
        ~DestructerTest()
        {
            Debug.Log("[3] �Ҹ�");
        }

    }

}
