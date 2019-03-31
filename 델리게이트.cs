using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Action 사용하기위해 필요함.
public class tttest : MonoBehaviour
{
    // Start is called before the first frame update

    //action과 func도 델리게이트를 줄여놓은것
    delegate void MyDelegate<T1, T2>(T1 a, T2 b);
    MyDelegate<int, int> myDelegate;
    Action<int, int> myDelegate2; // 위에 마이델리게이트 선언부 없어도됨. system에 있는걸 갖다쓰는거임.
    Func<int, int, string> myDelegate3;
    void Start()
    {
        myDelegate3 = (int a, int b) => { int sum = a + b; return sum + "이 리턴되었습니다."; };
        print(myDelegate3(3, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
