using UnityEngine;

namespace OverrideDemoTest
{
    //�θ� Ŭ����
    public class Parent
    {
        //�޼���
        public void Say() => Debug.Log("�θ� �ȳ��ϼ���");
        public void Run() => Debug.Log("�θ� �޸���");
        public virtual void Walk() => Debug.Log("�θ� �ȴ�");
    }

    //Parent Ŭ������ ��ӹ޴� �ڽ� Ŭ����
    //�θ� Ŭ������ �޼��带 �������ؼ� ���
    public class Child : Parent
    {
        //[1] ������ - �׳� �����ٰ� �������Ѵ�
        //public void Say() => Debug.Log("�ڽ� �ȳ��ϼ���");
        public new void Say() => Debug.Log("�ڽ� �ȳ��ϼ���");
        //[2] ������ - new Ű���带 ����Ѵ�
        public new void Run() => Debug.Log("�ڽ� �޸���");
        //[3] ������ = vitual ���ǵ� �Լ��� override Ű����� ������ �Ѵ�
        public override void Walk() => Debug.Log("�ڽ� �ȴ�");
        

        
    }

}
