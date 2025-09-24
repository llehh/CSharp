using UnityEngine;

namespace Property
{
    //�� �����͸� �����ϴ� Ŭ����
    public class User
    {
        //�ʵ�
        private int birthYear;      //����
        
        //�ڵ� �Ӽ�
        public string Name { get; set; }  //�̸�

        //���� ���� �Ӽ�
        public int BirthYear
        {
            set 
            {
                if (value >= 1900)
                {
                    birthYear = value;
                }
                else 
                {
                    birthYear = 0;
                }
                
            }
        }

        //�б� ���� �Ӽ�
        public int Age
        {
            get 
            {
                return (System.DateTime.Now.Year - birthYear); 
            }
        }

        //������ - �Ű������� �޾Ƽ� �Ӽ��� �ʱ�ȭ
        public User(string name)
        { 
            Name = name;
        }

    }
}
