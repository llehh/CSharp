using UnityEngine;

namespace InheritanceBaseTest
{
    //�ڽ�Ŭ����
    public class My : Car
    {
        //������
        public My() : this("���� �ڵ���")
        { 
                
        }

        public My(string _name) : base(_name) 
        { 
            
        }

    }

    //�ڽ� Ŭ����
    public class Your : Car
    {
        //������
        public Your() : base("���� �ڵ���")
        { 
            
        }
    }
}

/*
�ڽ�(���� Ŭ����) �ν��Ͻ�, �ڽ� ������
this, this()

�θ� Ŭ���� �ν��Ͻ�, �θ� ������
base, base()
*/
