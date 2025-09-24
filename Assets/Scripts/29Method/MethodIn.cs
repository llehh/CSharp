using UnityEngine;

namespace Method
{
    //��ġ�� �����ϴ� ����ü
    public struct Point
    { 
        public int x; 
        public int y;
    }

    //[1] �� ���� ���   (int num), ����ü
    public class MethodIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //������ ���� num �����ϰ� �ʱ�ȭ
           /* int num = 10;
            Debug.Log($"[1]: {num}");   //10

            PrintNumber(num);

            Debug.Log($"[3]: {num}");       //10*/

            //����ü ���� �����ϰ� �ʱ�ȭ
            Point point = new Point();
            point.x = 10;
            Debug.Log($"[1]: {point.x}");   //10

            PrintNumber(point);

            Debug.Log($"[3]: {point.x}");   //10

        }

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]: {num}");       //20
        }

        private void PrintNumber(Point P)
        {
            P.x = 20;
            Debug.Log($"[2]: {P.x}");       //20
        }


    }

}
