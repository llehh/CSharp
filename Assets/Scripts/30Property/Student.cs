using UnityEngine;

namespace Property
{

    public class Student
    {
        //�ʵ�
        private string name;
        private string address;

        //�Ӽ�
       /* public string Name
        { 
            get {return name;}
            set {name = value;}
        }*/

        public string Name
        {
            get => name;
            set => name = value; 
        }


        //�ڵ��Ӽ�
        public int Age { get; set; }

        public int Number { get; set; } = 1;    //�ڵ��Ӽ��� ����� ���ÿ� �Ӽ� �ʱ�ȭ ����

        //�޼��带 �̿��Ͽ� address �б�,����
        public void SetAddress(string _address)
        { 
            this.address = _address;
        }

        public string GetAddress()
        { 
            return this.address;
        }
                                                
    }
}