using UnityEngine;

namespace AbstractMustTest
{
    //�߻� Ŭ������ ��� �޴� �ڽ� Ŭ����
    //�߻� Ŭ������ �����ϴ� ����� �����Ѵ�
    public class Person : GeneralManager
    {
        //��ӹ��� �߻� �޼��� ����
        public override void SayTalk()
        {
            Debug.Log("��� ���� �߻� �޼��带 �����Ѵ�");
        }
    }
}

/*
�߻� Ŭ������ �����ϴ� ����� �����ؾ� �Ѵ�
��� ���� �߻�Ŭ������ �߻� �޼��� �����ϱ�
public override void �߻�޼����̸� ()
{
 
}
*/