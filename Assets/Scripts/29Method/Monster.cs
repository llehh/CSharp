using UnityEngine;

namespace Method
{
    //���͸� �����ϴ� Ŭ����
    public class Monster
    {
        //�ʵ�
        //������� ����: ���ϳ��� ����, ����
        //������ ������ ����
        public static int monsterCount = 0;

        public int hp;   //ü��
        public int atk;  //���ݷ�

        //������ - �Ű������� ���� ������ �ʵ� �ʱ�ȭ
        public Monster(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }

        //�������� �Դ� �Լ�- �Ű������� ���� �������� ��ŭ hp�� ����ȴ�
        public void TakeDamage(int damage)
        { 
            hp -= damage;
        }

    }
}
