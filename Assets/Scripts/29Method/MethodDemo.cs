using UnityEngine;

namespace Method
{
    public class MethodDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Rectangle Ŭ������ �ν��Ͻ��� ����
            Rectangle rect = new Rectangle();
            Debug.Log(rect.GetName());
        }

    }

    public class Rectangle
    {
        //�޼���
        public string GetName()
        {
            return "���簢��";
        }
    }

}

/*
�޼���(Method), �Լ�(function)
:Ŭ������ ������ �� �ִ� ��ɵ��� ���� �ٸ� �̸����� ���� ����(����)�ϴ� �ڵ� ���

����������       ����      ��ȯŸ��
public(private) static(x) void(int, string ...) �޼����̸� (�Ű�����)
{
    //�޼����� ���๮��...

    //return ��ȯŸ��
}

�޼��� �̸�
: �̸��� ù ���ڴ� �빮�ڷ� ����
: ���� + ���
~�� �����´� : GetName, GetHp, GetMoeny
��  ���� : SetName("ȫ�浿")
*/
