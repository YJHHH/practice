using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student : human
{

    string schoolName;
    // Start is called before the first frame update
    void Start()
    {
        schoolName = "elementary school";
        humanName = "jh";
        humanAge = 14;
        //student 클래스, 즉 학생은 인간이기 때문에 human name과 age를 사용하고싶다.
        //그래서 상속을 이용한다.
        info();
    }
    protected override void info()
    {
        base.info(); //base <-부모클래스 휴먼
        print("나는 학생입니다.");
        //재정의 가능한 점이 virtual 과 override 의 기능.
    }
    // Update is called once per frame

    protected override void Name()
    {
        print(humanName);
    }
    //추상함수. 완성을 자식클래스에서 시켜야 한다. 까먹고 함수를 안만드는 일이 없어진다.
    //미리 토대를 만들어줌=다형성.
   
    void Update()
    {
        
    }
}
