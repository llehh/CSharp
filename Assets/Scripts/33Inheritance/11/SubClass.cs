using UnityEngine;

namespace InheritanceFieldTest
{
    //�ڽ� Ŭ����
    public class SubClass : BaseClass
    {
        public void SetWord(string _word)
        { 
            base.Word = _word;
        }

        public string GetWord()
        {
            return base.Word;
        }
    }
}
