using Constructor;
using UnityEngine;

namespace Indexer
{
    public class IndexerNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PersonŬ������ �ν��Ͻ� ����
            Person person = new Person();

            //�ε��� ���
            person[0] = "ȫ�浿";
            Debug.Log(person[0]);   //ȫ�浿

            person[1] = "��λ�";
            Debug.Log(person[1]);   //��λ�

            Debug.Log(person[0]);   // ��λ�

        }

    }
}
