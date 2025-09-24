using UnityEngine;

namespace Generic
{
    //���׸� Ŭ���� ���� <T>: �ʵ�, �޼��� Ȱ�� 
    public class Hello<T>
    {
        //[1] �ʵ�
        private T message;

        //[2] ������ -
        public Hello()
        {
            //�ʵ� �ʱ�ȭ : �����ϴ� Ÿ���� ����Ʈ ���� ���ͼ� �ʱ�ȭ�Ѵ�
            message = default(T); 
        }

        //�Ű������� TŸ���� ���� �Է¹޾� �ʵ� �ʱ�ȭ
        public Hello(T _message)
        { 
            this.message = _message;
        }

        //�޼���
        public void Say(T _msg)
        { 
            Debug.Log(_msg);
        }

        public T GetMessage()
        { 
            return this.message;
        }
    }
}
