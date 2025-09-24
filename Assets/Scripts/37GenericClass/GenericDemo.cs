using UnityEngine;

namespace Generic
{
    public class GenericDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cup<T> Ŭ������ �ν��Ͻ� ����
            // <T> ������ �ν��Ͻ� ������ �����Ѵ�
            //Cup cup = new Cup();  ����

            //[1] T�� string�� �����Ͽ� ���ڿ��� �����ϴ� �Ӽ��� ���� �ν��Ͻ� ����
            Cup<string> text = new Cup<string>();
            text.Content = "���ڿ�";

            //[2] T�� int�� �����Ͽ� ������ ���ڸ� �����ϴ� �Ӽ��� ���� �ν��Ͻ� ����
            Cup<int> number = new Cup<int>();
            number.Content = 1234;

            Debug.Log($"{text.Content} + {number.Content}");

            //[3] ����: T�� Water�� �����Ͽ� ������  ������
            Cup<Water> water = new Cup<Water>();
            water.Content = new Water();
            Debug.Log(water.Content.ToString());

            Cup<Coffee> coffee = new Cup<Coffee>();
            coffee.Content = new Coffee();
            Debug.Log(coffee.Content.ToString());
        }
    }
}

/*
���׸� Ŭ���� �����
���׸� Ŭ���� : ���� �Ű����� T�� ������ �������� Ŭ������ �ɹ��� ������ �����Ǵ� Ŭ����
Generic class: Cup<T> �ž��Ƽ, ������
 
����
public class Ŭ�����̸�<T>
{
    
}
*/
