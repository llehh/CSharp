using UnityEngine;

namespace Constructor
{
    public class ContructorOverload : MonoBehaviour
    {
       
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //constructorLog Ŭ������ �ν��Ͻ� ����
            //�⺻ �����ڸ� ȣ���Ͽ� �ν���Ʈ ����
            ConstructorLog log1 = new ConstructorLog();
            //�Ű�����  string �� �ִ� �����ڸ� ȣ���Ͽ� �ν���Ʈ ����
            ConstructorLog log2 = new ConstructorLog("ȫ�浿");
            //�Ű����� string �� �ִ� �����ڸ� ȣ���Ͽ� �ν���Ʈ ����
            ConstructorLog log3 = new ConstructorLog("��λ�");    
        }

    }
}

