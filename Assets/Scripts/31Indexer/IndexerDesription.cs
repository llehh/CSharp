using UnityEngine;

namespace Indexer
{

    public class IndexerDesription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car Ŭ������ �ν��Ͻ��� ����
            Car car = new Car(3);
            car[0] = "���׽ý�";
            car[1] = "�׷���";
            car[2] = "�ƹ���";

            //�ε��� ���
            //for (int i = 0; i < car.Length; i++)
            //{
            //    Debug.Log(car[i]);
            //}

           foreach (var c in car)
            {
               Debug.Log(c);     
            } 

        }

    }
}