using UnityEngine;
using AbstractDemoTest;
namespace Inheritance
{

    public class AbstractDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�θ� Ŭ������ �ν��Ͻ�(��ü) ����
            //ParentClass parent = new ParentClass();  //�߻� Ŭ������ �ν��Ͻ��� ���� �Ұ�

            ChildClass child = new ChildClass() { Id = 1, Active = true, Name = "ȫ�浿" };
            if (child.Active == true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }

        }

    }
}
/*
Abstract Class (�߻� Ŭ����) 
: �ڽ��� ��� ���� �ڽ� Ŭ�������� ������ ����� �߰��ϵ��� �Ѵ�
: �ڽ� Ŭ������ ������ ����� �����ϵ��� �����Ѵ�
: �߻� Ŭ������ �ν��Ͻ�(��ü)�� ���� �� ����
: �߻� Ŭ������ �ٸ� Ŭ������ �θ� Ŭ�����θ� ����� ����

���� ����
public abstract class �߻�Ŭ�����̸�
{

}

: �ڽ� Ŭ�������� ������ ����� �����ϵ��� �����Ѵ�

�߻� �޼��� : ������ ���(�޼���)
            : �޼��� �����κ�(����, �ڵ��� �κ�) ����

�߻� �޼��� ���� ����
public abstrate void (�߻�޼����̸�) ();
*/
