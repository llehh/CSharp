using UnityEngine;

namespace Property
{
    public class PropertyPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //page Ŭ������ �ν��Ͻ� ����
            Page page = new Page();
            //page.Message = "�ܺο��� ���� �Ұ���";
            Debug.Log(page.Message);

            //User Ŭ������ �ν��Ͻ�
            User user = new User("ȫ�浿");
            user.BirthYear = 2005;
            Debug.Log($"�̸�:{user.Name}, ����:{user.Age}");
        }

    }

    //Private �� Property
    public class Page
    {
        //�ʵ�
        //private string name;

        //Property
        public string Message { get; private set; } = "�б� ���� �Ӽ�";

    }
}
