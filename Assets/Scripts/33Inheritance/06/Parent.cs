using UnityEngine;

namespace InheritanceConstructorTest
{
    //�θ� Ŭ����
    public class Parent
    {
        //�Ӽ�(property)
        public string Word {  get; set; }

        //������ - �Ű������� �Է� �޾� �Ӽ� �ʱ�ȭ
        public Parent(string word)
        { 
            this.Word = word;
        }

    }
}
