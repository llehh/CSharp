using UnityEngine;

namespace MethodOverride
{
    public class MethodOverrideTostring : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person Ŭ������ �ν��Ͻ� �����
            Person person = new Person("ȫ�浿");

            //��ü�� ���ڿ��� ����ϸ� TOString() ȣ��ȴ�
            Debug.Log(person);

        }


    }
}
