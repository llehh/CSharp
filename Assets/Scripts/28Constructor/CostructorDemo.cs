using UnityEngine;

namespace Constructor
{
    public class CostructorDemo : MonoBehaviour
    {
       /* //������ �޼���
        public CostructorDemo()
        {
            Debug.Log("�����ڰ� ȣ��Ǿ����ϴ�");
        }*/

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //CostructorDemo Ŭ������ �ν��Ͻ��� ����
            //CostructorDemo cons = new CostructorDemo();

            //Student Ŭ������ �ν��Ͻ�(��ü)�� ���� - Student Ŭ������ ������ ȣ��
            Student student = new Student();

        }


    }

}

/*
������(Constructor)
: Ŭ������ ���ɶ� ���� ���� ȣ��Ǵ� �޼���
: Ŭ������ �ʵ�,�Ӽ����� �⺻���� �����ϴ� ������ �Ѵ�

������(Constructor)
:�޼���
:Ŭ���� �̸��� ������ �̸��� ���
:���� �����ڴ� public �� ���
:��ȯ���� ����, void�� ����

- �����ڸ� ������ ������ �⺻ �����ڸ� �ڵ����� ����� �ش�
- �����Ǵ� �ν��Ͻ�(��ü)�� �ʵ�,�Ӽ����� ���� �������� �ʾ��� ��� �⺻������ �ʱ�ȭ, 
- �⺻��: ���� ���� zero(0), ��������: null
class Date
{
    //������ - �⺻ ������
    public Date()
    {
    }
}
*/


