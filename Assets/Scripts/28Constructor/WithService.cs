using UnityEngine;

namespace Constructor
{
    public class WithService
    {
        //�ʵ� �����
        //�б� ���� �ʵ�
        private readonly string serviceName;

        //�⺻ ������
        //�����ڸ� ���ؼ� �б� ���� �ʵ嵵 �ʱ�ȭ�� �����ϴ�
        public WithService()
        {
            serviceName = "����";
        }

        public WithService(string service)
        {
            this.serviceName = service;
        }

        //�޼���
        public void Run()
        {
            Debug.Log($"{serviceName}�� �����մϴ�");
        }

    }

}
