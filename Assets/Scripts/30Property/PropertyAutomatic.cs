using UnityEngine;

namespace Property
{
    public class PropertyAutomatic : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truck Ŭ������ �ν��Ͻ� ����
            Truck truck1 = new Truck();
            truck1.Name = "���׽ý�";
            Debug.Log(truck1.Name);

            Truck truck2 = new Truck();
            truck2.Name = "�׷���";
            truck2.Color = "Red";
            Debug.Log($"���� Ʈ��: {truck2.Name}, {truck2.Color}");
        }

    }

}
