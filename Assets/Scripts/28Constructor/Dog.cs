using UnityEngine;

namespace Constructor
{
    public class Dog
    {
        //[1]�ʵ�
        private string name;

        //[2]������: �ʵ��� �ʱⰪ ����
        public Dog(string value)
        { 
            //�Ű������� ���� �޾Ƽ� name �ʵ� �ʱ�ȭ
            name = value;
        }

        //[3]�޼���
        public string Cry()
        {
            return name + "��(��) �۸۸�"; 
        }


    }

}
