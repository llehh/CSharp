using UnityEngine;

namespace Generic
{
    public class Water { }

    public class Coffee { }

    //Ŭ�����̸�<T> ���·� ���׸� Ŭ���� ����
    public class Cup<T>
    {
        //TŸ���� �Ӽ� ���
        public T Content { get; set; }
    }
}
