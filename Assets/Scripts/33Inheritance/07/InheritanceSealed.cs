using UnityEngine;
using InheritanceSealedTest;

namespace Inheritance
{
    public class InheritanceSealed : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ڽ� Ŭ���� ����
            Cat cat = new Cat();
            cat.Eat();
        }

    }

}
