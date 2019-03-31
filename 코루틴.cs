using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine : MonoBehaviour
{

    Coroutine myCoroutine1;
    Coroutine myCoroutine2;
    private IEnumerator myCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        /*
        LoopA();
        LoopB(); //루프 A가 전부 실행되고 나서 루프 B가 실행된다.
        */

        //루프 A와 B를 함께 실행시키는 방법= 코루틴. 병렬처리.
        myCoroutine = LoopA();
        StartCoroutine(myCoroutine); //LoopA에 파라미터가 많을 경우, 파라미터 포함한 함수를 변수에 담아서 돌림.

        myCoroutine1 =StartCoroutine(LoopA());
        myCoroutine2=StartCoroutine(LoopB());
        // 이러면 i와 x가 1초마다 번갈아가면서 나오게 된다.

        StartCoroutine(Stoooop());
    }

    // Update is called once per frame

    #region Loop
    IEnumerator LoopA()
    {
        for (int i = 0; i < 100; i++)
        {
            print("i의 값" + i);
            // yield return null; //한 프레임을 대기.
            yield return new WaitForSeconds(1f); //괄호 안 시간만큼 대기시킴. 대기시간동안 루프 B가 돈다.
        }
    }
    IEnumerator LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            print("x의 값" + x);
            yield return new WaitForSeconds(1f); //괄호 안 시간만큼 대기시킴. 대기시간동안 루프 A가 돈다.
        }
    }
    #endregion Loop  
    //region 사용하면 코드를 축약해서 볼 수 있다. (전처리 기능)

    IEnumerator Stoooop()
    {
        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine1);
        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine2);

        StopAllCoroutines(); //동작중인 모든 코루틴을 중지.
    }

    /*
    void LoopA()
    {
        for (int i=0;i<100;i++)
        {
            print("i의 값" + i);
        }
                }
    void LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            print("x의 값" + x);
        }
    }
    */
}
