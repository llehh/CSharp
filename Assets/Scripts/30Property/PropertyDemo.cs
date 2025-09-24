using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]Developer Ŭ������ �ν��Ͻ� ����
            Developer dev = new Developer();

            //[2]�Ӽ��� ���� ����
            dev.Name = "ȫ�浿";

            //[3]�Ӽ��� ���
            Debug.Log(dev.Name);

        }

    }

    //�Ӽ� ����
    public class Developer
    {
        //�Ӽ� �����
        public string Name { get; set; }
    }

}

/*
�Ӽ�(Property) : �ʵ��� ���� �аų� ���ų� �����ϴ� ����� �����ϴ� Ŭ���� ���
                 �ʵ��� ������������ �⺻�� private(�ܺο��� ������ �� �ȴ�)
                 �Ӽ��� ���� �ʵ带 �ܺο��� �аų� ���Ⱑ �����ϵ��� ���ش�

:�Ӽ��̸��� �� �ձ��ڴ� �빮�ڷ� ����Ѵ�
:�Ӽ��� ����� ������ �����ϴ�

�⺻����(���)
public [��ȯŸ��] �Ӽ��̸� { get; set; }
*/
