using UnityEngine;

namespace AbstractNoteTest
{
    public class AbstractNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Squre Ŭ������ �ν��Ͻ� ����
            Squre squre = new Squre(100);
            Debug.Log(squre.GetArea());

            //Circle Ŭ������ �ν��Ͻ� ����
            Circle circle = new Circle(10);
            Debug.Log(circle.GetArea());
        }

    }
}
