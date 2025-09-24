using JetBrains.Annotations;
/*
using UnityEngine;
using System;
namespace Delegate
{

    
    public class DelegateAll : MonoBehaviour
    {
        //[1] �븮�� ����(����) - ��ȯ���� ����, �Ű����� ����
        delegate void GoHome();
        //[2] �븮�� ���� ����
        GoHome go;

        //�λ��ϴ� �븮�� ����(����) - ��ȯ���� ����, �Ű����� ����
        delegate void say();

        //Action ������ ���� �븮�� ��ü�� ���� : Action, Func
        Action driver;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� -> ��ȸ�� -> ���� -> ��ȸ��

            //��������
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            Debug.Log("==========");

            //[2] �븮�� ������ �޼��� ���
            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);    //�޼��� ���
            go -= new GoHome(CarDriver.GoForward);    //�޼��� ���
            
            //[4] �븮�� ����(ȣ��)
            go.Invoke();

            Debug.Log("==========");

            //�븮�� ���� ���� �� �޼��� ���
            say say = new say(Hello);
            say += new say(Hi);
            say.Invoke();
            Debug.Log("==========");

            //Insa Ŭ������ �ν��Ͻ� ����
            Insa insa = new Insa();

            //�븮�� ���� ���� �� �޼��� ���
            Say say2 = insa.Bye;
            say2 += Hi();
            say2.Invoke();

            Debug.Log("==========");

            //Action
            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += () => Debug.Log("����");
            driver += delegate () { Debug.Log("����"); };  //���� �Լ�, �͸� �Լ�
            driver.Invoke();
        }

        void Hi()
        {
            Debug.Log("Hi");
        }

        void Hello() => Debug.Log("Hello");

    }
}

*/
    