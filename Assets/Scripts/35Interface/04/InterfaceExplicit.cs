using UnityEngine;

namespace InterfaceNoteTest
{
    public class InterfaceExplicit : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Pet Ŭ���� �ν��Ͻ� ����
            Pet pet = new Pet();
            ((IDog)pet).Eat();  //pet ��ü�� IDog�������� ���� ��ȯ
            ((ICat)pet).Eat();  //pet ��ü�� ICat�������� ���� ��ȯ

            //������, ��ĳ����
            IDog dog = new Pet();
            dog.Eat();

            ICat cat = new Pet();
            cat.Eat();

        }


    }
}
