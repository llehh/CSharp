using UnityEngine;
using AbstractMustTest;
namespace Inheritance
{
    public class AbstractMust : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ڽ� Ŭ������ �ν��Ͻ�(��ü) ����
            Person person = new Person();
            person.SayTalk();
        }

    }
}
