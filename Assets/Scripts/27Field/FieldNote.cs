using UnityEngine;

namespace Field
{

    public class FieldNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person Ŭ������ �ν��Ͻ� ����
            Person person = new Person();
            //Person �ν��Ͻ�(��ü)�� �̿��ؼ� Person Ŭ������ �ִ� public ����� �����ؼ� ���
            person.ShowProfile();
        }

    }
}
