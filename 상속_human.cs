using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class human : MonoBehaviour
{
    protected string humanName;
    protected int humanAge; //public private 지정안했을시 기본은 private. 같은 클래스 내에서 쓰이기 때문에 
    // 상속시에는 public으로 바꾸기
    // 그러나 이러면 타 클래스 모두에서 접근가능하기때문에
    // 상속받은 자식 클래스만 사용가능하게 하려면 protected 사용.
    protected virtual void info() //virtual: 부모 클래스의 info를, 자식 클래스가 수정(재정의)할 수 있게 함.
    {
        print("나는 인간입니다.");
        
    }

    abstract protected void Name(); //추상함수. 자식 클래스에서 기능을 완성시켜야 하는 함수.
                                    // 함수를 만들었는지 안만들었는지 헷갈릴 염려가 없어진다.
                                    // 추상함수를 쓰려면, 클래스도 추상 클래스로 만들어주어야 한다.
}
