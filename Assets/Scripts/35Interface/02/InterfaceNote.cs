using UnityEngine;

namespace InterfaceDemoTest
{
    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�������̽��� ���� ��ü�� �������̽��� ��ӹ��� Ŭ������ �ν��Ͻ� ���
            IRepository repository = new Repository();
            repository.Get();
        }
    }
}
