using UnityEngine;
using System.Collections;

namespace Generic
{
    //Ŀ���� List<T> �����
    public class MyList<T>
    {
        //�ʵ�
        private T[] values;
        private int length;

        //�Ӽ�
        public int  Length
         { 
            get { return length; } 
         }

        //������
        public MyList(int _length)
        { 
            this.length = _length;
            values = new T[length]; //TŸ�� ��Ҽ� ����
        }

        //�ε���
        public T this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        //�ݺ��� 
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            { 
                yield return values[i];
            }
        }

    }
}
