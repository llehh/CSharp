using UnityEngine;

namespace InheritanceBaseTest
{
    //�θ�Ŭ����
    public class Car
    {
        //�ʵ�
        private string name;

        //������ - �Ű������� �Է� �޾� �ʵ�(name) �ʱ�ȭ
        public Car(string _name)
        {
            this.name = _name;
        }

        //�޼���
        public void Run()
        {
            Debug.Log($"{this.name}�� �޸���");
        }

    }
}
