using UnityEngine;
using System.Collections.Generic;
namespace Generic
{
    //���� �����ϴ� Ŭ����
    public class User
    { 
        public string Name { get; set; }   //�� �̸�
        public int Number { get; set; }    //�� ��ȣ
    }

    //List<T> : T (int, string,.... ��������� ������ Ÿ��)
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�� ���� ����Ʈ �����ϰ� �ʱ�ȭ
            List<User> users = new List<User>
            {
                new User { Name = "ȫ�浿", Number = 1 },
                new User { Name = "����", Number = 2 },
                new User { Name = "��λ�", Number = 3 },
            };

            //����Ʈ�� �߰� (���� �߰�)
            //�߰��� User �ν��Ͻ� ����
            User user = new User() { Name = "��ܺ�", Number = 4 };
            users.Add(user);

            //����Ʈ ��� - �� ����Ʈ ���
            foreach (var us in users)
            {
                Debug.Log($"{us.Name} - {us.Number}");
            }

        }
    }
}