using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace Generic
{
    //�������� �����ϴ� Ŭ����
    public class Person
    { 
        public string Name { get; set; }
        //...
    }
    public class GenericCollection : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�� <����> ����Ʈ ���� �� �ʱ�ȭ
            List<Person> people = new List<Person>
            {
                new Person { Name = "ȫ�浿" },
                new Person { Name = "��λ�" },
                new Person { Name = "�Ӳ���" },
            };

            //����Ʈ ���
            foreach (var person in people)
            {
                Debug.Log(person.Name);
            }

        }
    }
}
/*
 ���׸� Ŭ���� : ���� �Ű����� T�� ������ �������� Ŭ������ �ɹ��� ������ �����Ǵ� Ŭ����
Generic class: Cup<T> �ž��Ƽ, ������
 */
