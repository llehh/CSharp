using UnityEngine;
using InheritanceFieldTest;

namespace Inheritance
{
    public class InheritanceField : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SubClass�� �ν��Ͻ� ����
            SubClass sub = new SubClass();
            sub.SetWord("�ʵ� ����� �� �ڽ� Ŭ�������Ը� ��� ���");
            Debug.Log(sub.GetWord());
        }

    }
}
