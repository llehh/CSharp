using UnityEngine;

namespace Method
{
    //[2] ���� ���� ��� (ref int num), Ŭ������ �ν��Ͻ�
    public class MethodRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� ����
            Monster monster1 = new Monster(100, 10);
            Monster.monsterCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.monsterCount++;

            //����
            //MonsterBattle(monster1, monster2);
            //MonsterBattle(monster2 , monster1);
            monster2.TakeDamage(monster1.atk);
            monster1.TakeDamage(monster2.atk);

            //UI
            Debug.Log($"monster1 hp:{monster1.hp}, atk:{monster1.atk}");
            Debug.Log($"monster1 hp:{monster2.hp}, atk:{monster2.atk}");
            Debug.Log($"Monster Count: {Monster.monsterCount}");


        }

        //�����ϴ� �Լ�, ����� : ü�� -= ���ݷ�
        //�Ű������� �����ϴ� ���Ϳ� ����ϴ� ���͸� �Է¹޾� ����� ����
        void MonsterBattle(Monster atkMonster, Monster defMonster)
        { 
            //�����
            defMonster.hp -= atkMonster.atk;
        }


    }

}
