using UnityEngine;

namespace InterfaceDemoTest
{
    //IRepository ��ӹ޴� Ŭ����
    public class Repository : IRepository
    {
        public void Get()
        {
            Debug.Log("Get() �޼��带 �����ؾ� �մϴ�");
        }
    }
}
