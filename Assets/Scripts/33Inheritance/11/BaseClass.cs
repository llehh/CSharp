using UnityEngine;

namespace InheritanceFieldTest
{
    //�θ� Ŭ����
    public class BaseClass
    {
        //[1]�ʵ� ���� - ���������� �⺻������ private
        private string word;

        //[2]�Ӽ� : private�� �ʵ忡�� ��ӹ��� �ڽ�Ŭ������ ���� ����
        protected string Word
        {
            get { return word; }
            set { word = value; }
        }

    }
}
