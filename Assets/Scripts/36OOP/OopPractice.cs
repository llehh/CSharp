//[1] ���ӽ����̽�
using UnityEngine;
using System.Collections;
//[1] ���ӽ����̽� ���� : Ŭ������ �浹 ����
namespace Oop
{
    //[2] �������̽� : ����, ǥ��, ��ӹ��� Ŭ������ �����ؾ� �� ��ɵ��� ����(����,ǥ��), ���� ��� ���� 
    public interface IStandard
    {
        //��� ����
        void Run();
    }

    /// <summary>
    ///[3] Ŭ���� : ���赵 
    /// </summary>

    public class Car : IStandard
    {
        #region [4] �ʵ�(��������, �������) : Private, Member, Variable
        private string name;    //�̸��� �����ϴ� ��������, ��ǰ
        private string[] names; //�迭�� �ʵ�
        private readonly int _Length; //�б� ���� �ʵ�
        #endregion

        #region [5] ������(Contrictor) : �ʵ� �ʱ�ȭ
        public Car()
        {
            this.name = "���� ��";
        }

        public Car(string name)
        { 
            this.name = name;
        }

        public Car(int length)
        {
            this.Name = "���� ��";        //�Ӽ��� ���� �ʵ� �ʱ�ȭ
            _Length = length;            //������ �ȿ����� �б� ���� �ʵ��� �ʱ�ȭ�� �����ϴ�
            names = new string[length];  //�Է¹��� �Ű����� ���̷� �迭 ��Ҽ� ����
        }
        #endregion

        #region [6] �޼���(Method) : ���/���� private, public
        public void Run() => Debug.Log($"{this.name} �ڵ����� �޸��ϴ�");
        #endregion

        #region [7] �Ӽ� : private�� �ʵ� => �ܺΰ���, public �Ӽ�
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Length
        { 
            get { return this._Length; } 
        }
        #endregion

        #region [8] �Ҹ���(Destructor) : ������ ��ü�� �Ҹ�ɶ� ���������� ȣ��
        
        ~Car()
        {
            Debug.Log($"{this.name} �ڵ����� ������");
        }
        #endregion

        #region [9] �ε���(Indexer) 
        public string this[int index]
        {
            get { return names[index]; }
            set {  names[index] = value; }
        }
        #endregion

        #region [10] ���ͷ�����(Iterators) : �ݺ���, �ε����� foreach������ ��밡���ϵ��� ��
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            { 
                yield return names[i];
            }
        }
        #endregion

        #region [11] �븮��(Delegate) : public, ���� �޼��� ȣ�� ����
        public delegate void EventHandler();
        #endregion

    }


    public class OopPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[A] Ŭ������ �ν��Ͻ� ����, �޼��� ȣ��
            Car campingCar = new Car("ķ��ī");
            campingCar.Run();                       //ķ��ī �ڵ����� �޸��ϴ�

            //[B] �Ӽ�
            Car sportsCar = new Car();
            sportsCar.Name = "������ī";
            sportsCar.Run();                //������ī�� �޸��ϴ�

            //[C] �ε���
            Car cars = new Car(2);
            cars[0] = "1�� �ڵ���";
            cars[1] = "2�� �ڵ���";
            for (int i = 0; i < cars.Length; i++)
            {
                Debug.Log(cars[i]);
            }

            //[D] �ݺ��� 
            foreach (var car in cars)
            {
                Debug.Log(car);
            }

            //[E] �븮��

        }

    }
}
