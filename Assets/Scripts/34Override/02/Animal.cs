using UnityEngine;

namespace MethodOverride
{
    //�θ�Ŭ����
    public class Animal
    {
        //virtual �� ǥ�õ� �޼��� : ��ӹ��� �ڽ�Ŭ������ ������ ���� override Ű���� ����϶�
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    //�ڽ�Ŭ����
    public class Dog : Animal
    {
        //virtual �޼��� ������ -> override Ű���� ���
        public override void Eat()
        {
            Debug.Log("�������� ���� �Դ´�");
        }
        
    }

}
