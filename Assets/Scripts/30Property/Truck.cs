using UnityEngine;

namespace Property
{
    //property auto: �ڵ����� �����Ǵ� �Ӽ� - �ʵ尡 ���� �Ӽ�
    //Ʈ���� ���¸� �����ϴ� Ŭ����: �̸�, ����
    public class Truck
    {
        //�̸�, ������ property���� ����

        //[1]�ʵ�� �Ӽ��� �Բ� ����Ͽ� �̸��� ����
        //�ʵ�
        private string name;
        //property
        public string Name 
        {
            get { return name; }     //�ܺο��� �����ؼ� �б�
            set { name = value; }    //�ܺο��� �����ؼ� ����
        }

        //[2]�ʵ� ���� �Ӽ��� ����Ͽ� ������ ���� - �ڵ� �Ӽ�
        public string Color { get; set; }

        //[3]�ڵ��Ӽ��� ����� ���ÿ� �ʱ�ȭ�� �����ϴ�
        public int Number { get; set; } = 1234;

    }
}
