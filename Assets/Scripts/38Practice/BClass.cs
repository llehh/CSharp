using UnityEngine;

namespace Practice
{
    public class BClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //AClass�� �ν��Ͻ� ��� �Լ� ȣ���ϱ�
            //AClass�� �ν��Ͻ� ����
            AClass aClass = new AClass();
            aClass.PrintWeekDays();

            //AClass�� ����(static) ��� �Լ� ȣ���ؼ� ��ȯ���� �� ����ϱ�
            //AClass�̸�.��������Լ��̸�
            Debug.Log(AClass.Sum(5, 6));
        }

    }
}
