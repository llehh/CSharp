using UnityEngine;

namespace Property
{
    //�ڵ����� ���¸� �����ϴ� Ŭ����
    public class Car
    {
        //�ʵ�
        private string color;

        //�ν��Ͻ� ������ �����ڸ� ���� �ʵ� �ʱ�ȭ
        //������
        public Car()
        {
            this.color = "Black";
        }

        //private�� color(�ʵ�)�� public�� �޼��带 �̿��Ͽ� �ܺο��� �б�, ����
        public void SetColor(string _color)
        { 
            this.color = _color;
        }

        public string GetColor()
        {
            return this.color;
        }

        //private�� color(�ʵ�)�� public�� �Ӽ�(property)�� �̿��Ͽ� �ܺο��� �б�,����
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //�б� ���� �Ӽ�
        public string Maker
        {
            get 
            {
                return "�����ڵ���";
            }
        }

        //Auto, �����
        public string Name { get; set; }


    }
}
