using UnityEngine;

namespace Property
{
    public class ObjectIntializer : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Student Ŭ������ �ν��Ͻ� ����
            Student s1 = new Student();
            s1.Name = "ȫ�浿";
            s1.Age = 16;
            Debug.Log($"�̸�:{s1.Name}, ����:{s1.Age}, ��ȣ:{s1.Number}");

            //��ü�̴ϼ� �������� ����Ͽ� ��ü �ʱ�ȭ
            Student s2 = new Student() { Name = "��λ�", Age = 16, Number = 2 };
            Debug.Log($"�̸�:{s2.Name}, ����:{s2.Age}, ��ȣ:{s2.Number}");

            Student s3 = new Student() { Name = "����", Age = 16, Number = 3 };
            s3.SetAddress("�����");
            Debug.Log($"�̸�:{s3.Name}, ����:{s3.Age}, ��ȣ:{s3.Number}, �ּ�:{s3.GetAddress()}");
        }

    }
}
