using UnityEngine;

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = int.MinValue;
        int max = int.MaxValue;

        Debug.Log("int 최소값: " + min);
        Debug.Log("int 최대값: " + max);
    }

    }



/*
정수형(Integer) 데이터 형식

SignedInteger ( +, - ) 부호가 있는 정수형 데이터 형식
sbyte : 8Bit = -128~127
short : 16Bit = -32768~32767
int   : 32Bit = -21억~+21억
long  : 64Bit

1Byte : 8비트 

UnSignedInteger 부호가 없는 정수형 데이터 형식
byte : 8Bit = 0~255
ushort : 16Bit = 0~65535 
uint   : 32Bit = 0~42억
long  : 64Bit

 */
