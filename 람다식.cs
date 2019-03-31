using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamb : MonoBehaviour
{

    int a=5;
    int b=5;
    int sum;

    void Add()
    {
        sum = a + b;
        Back(); //Back 은 Add 메소드에 종속되어버린다. 
    }

    void Print()
    {
        print(sum);
    }

    void Back()
    {
        sum = 0;
    }
    //여러 개의 함수를 동시에 호출시키기 위해 델리게이트 사용.
    delegate void MyDelegate();
    MyDelegate mydelegate;
    // Start is called before the first frame update
    void Start()
    {
        mydelegate = Add;
        //mydelegate += Print; // 이럴 바에는 print(sum)을 넣고싶지만, delegate 전후에 sum은 항상 0이다.
        //그래서 나온 게 무명 메소드. 함수를 만들지 않아도 델리게이트에 넣을 수 있다.
        mydelegate += delegate () { print(sum); }; //무명 메소드.
        //(int a) => return a; ex)매개변수 a를 받고 그 a를 반환하는 람다식.
        mydelegate += () => print(sum);// 람다식, 무명 메소드를 단순화시킨것. 
        mydelegate += Back;

        mydelegate(); //Add 와 Back 동시 호출됨.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
