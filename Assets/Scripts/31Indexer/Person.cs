using UnityEngine;

namespace Indexer
{
    public class Person
    {
        //�ʵ�
        private string name;

        //�ε��� ���� - �ε��� ��ȣ�� ��� ���� name �ʵ��� ���� �а� ���� �ε���
        public string this[int index]
        {
            get { return name; }     //�ν��Ͻ��̸�[�ε���] ȣ���ϸ� name �ʵ尪�� ��ȯ
            set { name = value; }    //�ν��Ͻ��̸�[�ε���] ȣ���ؼ� name �ʵ� ���� ������
        }
    }
}
