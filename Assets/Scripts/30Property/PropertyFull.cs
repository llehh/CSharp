using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person Ŭ������ �ν��Ͻ� ����
            Person person = new Person();

            //private �ʵ� ����(����- ��ȣ���� ������)
            //person.name = "ȫ�浿";

            //�Ӽ��� �̿��Ͽ� private �ʵ� �����б�
            person.Name = "ȫ�浿";
            Debug.Log(person.Name);

            //�޼��� �̿��Ͽ� private �ʵ� �����б�
            person.SetName("��λ�");
            Debug.Log(person.GetName());

        }

    }

}
