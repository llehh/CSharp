using UnityEngine;

namespace InterfaceDemoTest
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //CarŬ������ �ν��Ͻ� ����
            var car = new Car();
            car.Go();
        }
    }
}

/*
�������̽�(Interface)
: Ŭ�������� �����ؾ� �ϴ� ���� ��ɿ� ���� ���ǰ� ���Ե� ����
: Ư�� ���(�����ϴ� ���)�� �ݵ�� �����Ǿ�� ���� ����
: �������̽��� ��ӹ޴� Ŭ������ �������̽��� �����ϴ� ����� ���� �ϵ��� �����Ѵ�

: �������̽� �̸� : �� �� ���ڴ� �빮�� 'I' �� �����Ѵ� 

����
public interface �������̽��̸�
{
    //Ŭ�������� �����ؾ� �ϴ� ���� ��ɵ鿡 ���� ����
    //�޼��� ��� ����
    //�޼��� �����κ�(����, �ڵ��� �κ�) ����
}
 
*/
