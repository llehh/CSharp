using UnityEngine;

namespace Oop
{
    //ĸ��ȭ: �ʵ�� �⺻������ private ���� �ܺο� �������� �ʴ´�
    public class Person
    { 
        //[1]�ʵ�
        private string name;

        //[2]�޼��� : public�� �޼���(�Ӽ�)�� private�� �ʵ带 �ܺο� ������ �� �ִ�
        public void SetName(string name) => this.name = name;  
        public string GetName() => this.name;
    }

    public class OopDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();
            //ĸ��ȭ
            person.SetName("ȫ�浿");
            Debug.Log(person.GetName());
        }


    }
}
/*
��ü(��ü) ���� ���α׷����� �ϱ����� class�� �����
��ü(��ü) ���� ���α׷��� 4���� Ư��, ���� 
-���
-ĸ��ȭ
-������
-�߻�ȭ
 
*/
