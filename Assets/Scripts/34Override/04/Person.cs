using UnityEngine;

namespace MethodOverride
{
    public class Person
    {
        //�ʵ�
        private string name;    //��ü �̸�

        //������ : ������ �Ű������� ��ü�̸��� �Է� �޾� �����Ѵ�
        public Person(string name)
        { 
            this.name = name;
        }

        //ToString() �޼��� �������̵�
        public override string ToString()
        {
            return $"Person Ŭ����: {this.name}";
        }
    }
}
