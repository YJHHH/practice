using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//클래스에 형식 매개변수 이용하기.

public class Abc<T>
{
    public T var;
    public T[] array;
}







public class ttest : MonoBehaviour
{
    // Start is called before the first frame update

    Abc<string> a;
    Abc<float> b;


    void Print(int value)
    {
        print(value);
    }
    void Print(string value)
    {
        print(value);
    }
    void Print(float value)
    {
        print(value);
    }
    //같은 이름의 함수이나, 매개변수로 구분 가능.


    void Print<T> (T value) //where T: struct  //struct ,class 등 타입 지정 가능.
    {
        print(value);
    }


    void Start()
    {
        a.var = "abc";
        b.var = 4.5f;
        a.array = new string[1];
        b.array = new float[1];
        a.array[0] = "abc";
        b.array[0] = 4.5f;
        Print("abc"); // 이 경우는 string 매개변수
        Print(4.5f); //이 경우는 float 매개변수

        // 그러나 함수의 개수가 타입 개수만큼 많아져야되므로 불편하다.
        // 이럴 때 필요한 게 형식 매개변수.
        Print<string>("abc");
        //string 이 T 로 넘어가고, string value가 되어 abc를 입력받기 가능.
        Print<float>(4.5f);
    }

    //결국, 어떤 타입이 올 지 모를 때 사용한다는 것이 키 포인트.


    // Update is called once per frame
    void Update()
    {
        
    }
}
