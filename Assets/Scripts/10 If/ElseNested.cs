using UnityEngine;

//else 중첩문
//char c 문자 입력받아
//y 입력 받으면  YES 출력
//n 입력 받으면  NO  출력
//그 외의 문자가 들어오면 CANCLE
public class ElseNested : MonoBehaviour
{
    //
    public char c = 'a';


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]y 입력 받으면  YES 출력
        if (c == 'y') 
        {
            Debug.Log("YES");
        }  
        else  //'y'가 아니면
        {
            //[2]n 입력 받으면 NO  출력
            if (c == 'n') 
            {
                Debug.Log("NO");
            }

        }

    }


}
