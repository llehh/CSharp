using InheritanceBase;
using UnityEngine;

namespace Ingeitance
{
    public class InheritanceBaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SubŬ������ �ν��Ͻ� ����
            SubClass sub = new SubClass();

            //Base Ŭ������ (public, protected)���ǵ� �޼��� ��� ��� �����ϴ�
            sub.Do();

            //Base Ŭ������ (private)���ǵ� �޼���� ����� �Ұ����ϴ�
            //sub.Run();
        }
    }
}
