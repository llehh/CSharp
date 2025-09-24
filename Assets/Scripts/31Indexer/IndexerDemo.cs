using UnityEngine;

namespace Indexer
{
    public class Demo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Catalog Ŭ������ �ν��Ͻ��� ����
            Catalog ca = new Catalog();
            //�ε��� ȣ��: �ν��Ͻ��̸�[�ε���]
            Debug.Log(ca[0]);
            Debug.Log(ca[1]);
            Debug.Log(ca[2]);
            Debug.Log(ca[3]);
            Debug.Log(ca[4]);

        }

    }

    public class Catalog
    {
        //�ε��� ����
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}:¦��" : $"{index}:Ȧ��";
            }
        }
    }

}

/*  
Indexer(�ε���) : Ŭ������ �ν��Ͻ�(��ü)�� �迭ó�� [] �� ����� �� �ֵ��� ���ִ� ����
               : �ν��Ͻ��̸�[0], �ν��Ͻ��̸�[1], �ν��Ͻ��̸�[2]
               : Ŭ������(�ɹ��� �迭, �÷���)�� ���� �ε����� ȣ���ؼ� ���(�б�,����)�� �����ϰ� �Ѵ�

: ���� �ν��Ͻ��� �迭�̶�� ����� �ν��Ͻ��̸�[0].����̸����� ���

�ε��� ����  
Class car
{
}

Car cars = new Car(3);
cars[0] = "a";
cars[1] = "b";
cars[2] = "c";
*/