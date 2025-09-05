using System;
using UnityEngine;

public class StringDemo : MonoBehaviour

    // string(문자열) 데이터 형식
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1] string 변수 선언하고 초기화
        string name = "홍길동";
        string muliLine = @"
            안녕하세요
            반갑습니다
        ";
        

        //[2] 사용하기
        Debug.Log("안녕하세요" + name + "입니다" );
        Debug.Log(muliLine);
        */

        //문자열 보간법 (string Inrterpolation)
        string message = "문자열 보간법";
        string msg = string.Format("{0}님 {1}", "홍길동", "안녕하세요");

        Debug.Log("Message: " + message); //문자열 더하기 연산
        Debug.Log($"Message: {message}"); //문자열 보간법
        Debug.Log(msg);



    }
   
    
}
