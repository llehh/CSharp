using UnityEngine;

namespace InterfaceDemoTest
{
    //ICar �������̽��� ��ӹ޴� Car Ŭ���� ����
    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("����� �������̽��� ���ǵ� ��� ����� �ݵ�� �����ؾ� �Ѵ�");
        }
    }
}
