using UnityEngine;

namespace Property
{
    public class PropertyAll : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //CarŬ���� �ν��Ͻ� ����

            //[1]Get,Set �޼��� �̿� - ������ �ڵ���
            Car car1 = new Car();
            car1.SetColor("Red");
            Debug.Log(car1.GetColor());

            //[2]�Ӽ��� �̿� - ��� �ڵ���
            Car car2 = new Car();
            car2.Color = "White";
            Debug.Log(car2.Color);

            //[3]�б� ����
            Car car3 = new Car();
            //car3.Maker = "����ڵ���"; �б� �������� ���� �Ұ�
            Debug.Log(car3.Maker); 

            //[4] ����� �Ӽ�
            Car myCar = new Car();
            myCar.Name = "�պ�";
            Debug.Log(myCar.Name);

        }

    }
}
