using UnityEngine;

//동물들을 관리하는 enum
enum AnimalW
{ 
    Chicken,
    Dog,
    Pig
}



public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
        AnimalW animal = AnimalW.Pig;
        PrintAnimal(animal);
    }

    //열거형 AnimalW의 변수를 매개변수로 받아서 한글 동물이름을 출력하는 기능 구현
    void PrintAnimal(AnimalW ani)
    {
        //값을 비교해서 분기
        switch(ani)
        { 
            case AnimalW.Chicken:
                Debug.Log("닭");
                break;

            case AnimalW.Dog:
                Debug.Log("개");
                break;
                
            case AnimalW.Pig:
                Debug.Log("돼지");
                break;
        }
    }

}
