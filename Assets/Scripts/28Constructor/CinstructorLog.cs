using UnityEngine;

namespace Constructor
{
    public class ConstructorLog
    {
       //�⺻ ������
        public ConstructorLog()
        {
            Debug.Log("�⺻ ������ ����");     
        }

      //�Ű����� string �� �ִ� ������
      public ConstructorLog(string message)
        { 
            Debug.Log($"�����ε� �� ������ ����: {message}");
        }

        //...
    }

}



/*
������ Overload: �Լ��� ���� ����
:������ �̸��ǻ����ڸ� �Ű������� �޸��ؼ� ������ ����(����)  
*/