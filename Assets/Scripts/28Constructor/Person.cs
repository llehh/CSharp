using UnityEngine;

namespace Constructor
{
    public class Person
    {
        //[1]�ʵ�
        private string name;

        //[2]������: �Ű�����x, �ʵ� �ʱ�ȭ
        public Person()
        {
            name = "ȫ�浿";
        }

        //[3]�Ű������� �ִ� ������ - �Ű������� �Է� �޾� �̸��� �ʱ�ȭ
        public Person(string value)
        { 
            name = value;
        }
        //[4]�ż��� - �̸����� �ܺο��� ����ϵ��� �޼��� ����
        public string GetName()
        { 
            return name;
        }
    }
}
