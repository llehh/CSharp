using UnityEngine;

namespace Constructor
{
    public class ConstructorNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog Ŭ������ �ν��Ͻ� ����
            Dog happy = new Dog("����");
            Debug.Log(happy.Cry());

            //Dog Ŭ������ �ٸ� �ν��Ͻ� ����
            Dog worry = new Dog("����");
            Debug.Log(worry.Cry());

            //My Ŭ������ �ν��Ͻ� ����
            My my = new My("ȫ�浿", 20);
            my.PrintMyInfo();

        }


    }

}
