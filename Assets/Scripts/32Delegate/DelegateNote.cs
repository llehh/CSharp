using UnityEngine;

namespace Delegate
{
    //��ȯ���� �ְ�, �Ű������� �ִ� �޼����� ��������Ʈ �����
    public class DelegateNote : MonoBehaviour
    {
        //[1]��������Ʈ ����(����) - double�� ��ȯ, �Ű����� int 
        //delegate double �븮���̸� (int)
        delegate double GetCircleArea(int r);

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2]��������Ʈ ���� �����ϰ� �޼��� ���
            GetCircleArea area = GetArea;

            //[3]��������Ʈ ȣ��
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));

        }

        //�޼��� 
        //�Ű������� �������� ���̸� �Է¹޾� ���� ������ ����Ͽ� ��ȯ�ϴ� �Լ�
        private double GetArea(int r)
        { 
            return 3.14 * r * r; 
        }

    }
}
