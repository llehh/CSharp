using UnityEngine;

namespace Field
{
    public class Person
    {
        //�ʵ� ����
        //[1] ���� ������ �ʵ�
        private string name = "ȫ�浿";
        //[2] ��� ������ �ʵ�
        private const int AGE = 20;
        //[3] �б� ���� ������ �ʵ� 
        private readonly string NickName = "������";
        //[4] �迭 ������ �ʵ�
        private string[] address = { "����", "��õ", "����" };
        //[5] object ������ �ʵ�
        private object all = System.DateTime.Now.ToShortTimeString();

        //[6] public�� �޼���
        public void ShowProfile()
        {
            Debug.Log($"�̸�:{name}, ����:{AGE}, ����:{NickName}, �ּ�:{address[0]}");
        }

    }

}
