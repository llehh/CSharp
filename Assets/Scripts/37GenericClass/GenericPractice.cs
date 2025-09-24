using UnityEngine;

namespace Generic
{
    public class GenericPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //MyList<T> �ν��Ͻ� ���� - int ����
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            for (int i = 0; i < numbers.Length; i++)
            { 
                Debug.Log(numbers[i]);
            }

            //MyList<T> �ν��Ͻ� ���� - string ����
            MyList<string> names = new MyList<string>(3);
            names[0] = "ȫ�浿";
            names[1] = "��λ�";
            names[2] = "����";
            
            foreach (string name in names)
            {
                Debug.Log(name);
            }
        }

    }
}
