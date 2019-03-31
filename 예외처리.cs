using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class except : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            c = a / b; //divide by zero error 발생.

        }
        catch (DivideByZeroException ie)// 해당오류 발생시 대처.
        {
            print(ie);
            b = 1;
            c = a / b;
            //print(c);
        }
        finally
        {
            print(c);//오류가 발생하던말던 실행되는것.
        }

        throw new Exception("일부러 오류를 발생시킴");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
