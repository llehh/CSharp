using UnityEngine;

namespace MethodOverride
{
    //�θ� Ŭ����
    public class ParentClass
    {
        public virtual void Hi()
        {
            Debug.Log("�θ� �ȳ��ϼ���");
        }
    }

    //�ڽ� Ŭ����
    public class ChildClass : ParentClass
    {
        public override void Hi()
        {
            Debug.Log("�ڽ� �ȳ��ϼ���");
        }
    }
}
