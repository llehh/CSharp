using UnityEngine;
using UnityEngine.Rendering;

namespace Property
{
    public class Person
    {
        //�ʵ�
        private string name;    //�̸�

        //public [��ȯŸ��] �Ӽ��̸� { get; set; }
        //�ʵ��� ���� �аų� ���ų� �����ϴ� ����� �����ϴ� Ŭ���� ���
        //�Ӽ�(property)�� �̿��ؼ� name�� ���� ���
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }


        //private �� �ʵ带 public�� �޼��带 �̿��Ͽ� ���� �д´�
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }

    }

}
