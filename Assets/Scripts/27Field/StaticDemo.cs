using UnityEngine;

namespace Field
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truck Ŭ������ ����(static) ��� ����ϱ�
            //Ŭ�����̸�.��������̸� ���� �����ؼ� ����Ѵ�
            Truck.name = "ȫ�浿";
            string tName = Truck.GetName();
            Debug.Log(tName);

            //Truck.age = 20; (x)

            //Truck Ŭ������ �ν��Ͻ�(instance) ��� ����ϱ�
            //Truck Ŭ������ �ν��Ͻ�(instance) ����
            //������ �ν��Ͻ�(instance)�̸�.�ν��Ͻ�����̸� ���� �����ؼ� ���
            Truck truck = new Truck();
            //truck.age = 20; (��ȣ���� ����, private) 
            truck.SetAge(20);
            Debug.Log(truck.GetAge());
            
        }

    }

}
