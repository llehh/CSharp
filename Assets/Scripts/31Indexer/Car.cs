using UnityEngine;
using System.Collections;

namespace Indexer
{
    public class Car
    {
        //�迭������ �ʵ�
        private string[] names;

        //�Ӽ� - names �迭�� ���� - �б� ����
        public int Length
        { 
            get { return names.Length; }
        }


        //������ - �Ű����� �迭�� ũ�⸦ �������ش�
        public Car(int length)
        {
            //�迭�� ��Ҽ� ����
            names = new string[length];
        }

        //�ε��� - names �迭 �ʵ��� ���� �а� ���� �ε��� 
        public string this[int index]
        {
            get //�ν��Ͻ��̸�[�ε���] ȣ���ϸ� names[�ε���] �ʵ尪�� ��ȯ
            {
                return names[index];
            }
            set //�ν��Ͻ��̸�[�ε���] ȣ���ؼ� names[�ε���] �ʵ� ���� ����
            { 
                names[index] = value;
            }
        }

        //�ݺ��� 
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}
