using UnityEngine;

namespace Constructor
{ 
    public class My
    {
        //�ʵ� �����
        private string name; //�̸�
        int age;             //����, ���������ڰ� ����, private

        //������ - �̸��� ���� ������ ���� �Ű������� �޾� �ʱ�ȭ
        public My(string name, int age)
        { 
            this.name = name;
            this.age = age;
        }

        //�޼���
        public void PrintMyInfo()
        {
            Debug.Log($"�̸�:{this.name}, ����:{this.age}");
        }

    }

}
