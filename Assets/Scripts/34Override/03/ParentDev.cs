using UnityEngine;

namespace MethodOverride
{
    //�θ� Ŭ����
    public class ParentDev
    {
        //�����ǰ� ������ �޼���
        public virtual void Work()
        {
            Debug.Log("���α׷���");
        }
    }

    //�ڽ� Ŭ����
    public class ChildDev : ParentDev
    {
        //virtual -> override
        //sealed Ű���带 �̿��Ͽ� ��� ����
        public override sealed void Work()
        {
            //base Ű����� �θ� ������� ������ ����
            base.Work();
        }
    }

    //���� Ŭ����
    public class GrandChildDev : ChildDev
    {
        //����� ����(sealed)�Ǿ� ������ �Ұ�
        //public override void Work()
        //{
        //    base.Work();
        //}

        public void Play()
        {
            Debug.Log("���ΰ��̸�");
        }

    }
}
