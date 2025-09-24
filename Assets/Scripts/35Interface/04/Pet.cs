using UnityEngine;

namespace InterfaceNoteTest
{
    //IDog, ICat �� ��ӹ޴� Ŭ����
    public class Pet : IDog, ICat
    {
        //��������� IDog ����
        void IDog.Eat()
        {
            Debug.Log("Dog Eat");   
        }

        //��������� ICat ����
        void ICat.Eat()
        {
            Debug.Log("Cat Eat");
        }
    }
}
