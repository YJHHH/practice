using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ChainFunction(int value); //델리게이트 체인. setpower, setdefence 메소드를 대신 호출시켜준다. 
    //호출할 메소드와 동일한 반환타입인 void로 지정. 매개변수타입도 value와 같이 int로 지정한다.
    //이 경우는 하나의 델리게이트에 여러 개의 메소드가 연결된 델리게이트 체인이다.
    //하나 클래스 내의 메소드를 다룰 수 있다.


    public static event ChainFunction OnStart;
    //이벤트는 여러 클래스 내의 메소드를 전부 관리할 수 있다.
    //ChainFunction chain;
    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power는 " + power + "입니다");
    }
    public void SetDefence(int value)
    {
        defence += value;
        print("defence 의 값이" + value + "만큼 증가했습니다. 총 defence 는 " + defence + "입니다");
    }
    void Start()
    {
        

        OnStart += SetPower; //참조된 메소드 호출.
        OnStart += SetDefence; 
        OnStart -= SetDefence; //메소드 끊기.
       
        //if (chain !=null) chain(5);
        //근데 렙업할때마다 5씩 계속 setpower, setdefence 함수 써가면서 올리기는 힘들다. 이걸위해 델리게이트를 사용한다.

    }

    // Update is called once per frame
    private void OnDisable()
    {
        OnStart(5); //게임이 꺼지면 세 개의 함수가 동시에 실행된다.
    }
}
