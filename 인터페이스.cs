using System.Collections;
using System.Collections.Generic;
using UnityEngine;
abstract public class A: MonoBehaviour
{
    abstract public void Abc(); //미완성 함수 선언.
}

interface ITest
{
    //뼈대 제공, 다중 상속.
    //함수, 프로퍼티, 인덱서, 이벤트 선언 가능.
    void Bbc();
    int SalaryP { get; set; }
    // int a; 인터페이스는  변수선언안됨.
}
interface ITest2 : ITest
{ }//인터페이스끼리 상속 가능.
public class Test1 : A,ITest //A 클래스 상속하기. 클래스는 A,B 클래스 모두를 상속받을수는 없다. 인터페이스를 이용, 다중상속하기.
{
    public int SalaryP { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Bbc() //재정의 시, 오버라이드 안함.
    {
        print("ㅁㅁ");
    }

    public override void Abc()
     {
        print("ㅁㅁ");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
