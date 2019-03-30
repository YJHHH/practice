using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NewBehaviourScript2.OnStart += Abc; //시작하자마자 onstart에 abc함수도 담겨서 실행된다. 서로 다른 클래스인데 setpower,defence, abc 모두가 담긴다.
    }
    public void Abc(int value)
    {
        print(value + "의 값이 증가했습니다.");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
