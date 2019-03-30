using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    //컬렉션 : 리스트 ,큐,스택, 해시테이블,딕셔너리,어레이리스트

    ArrayList arrayList = new ArrayList();

    List <int> arrList=new List<int>();// 특정 자료형만 넣어야 한다. 연산량이 어레이리스트보다 적다.

    Hashtable hashTable = new Hashtable();

    Dictionary<string, int> dic = new Dictionary<string, int>(); //해시테이블과 다른 점은, 자료형이 정해져있다는 것.

    Queue<int> queue = new Queue<int>(); //enqeue, deqeue 값 넣기, 빼기만 가능. 큐에 원소가 남아있는지 잘 확인해줘야함. FIFO 선입선출
    //ex) 포션 제작 대기줄. 마지막에 클릭한 포션이 마지막에 제작된다.
    Stack<int> stack = new Stack<int>(); //push pop 으로만 한다. 근데 LIFO 후입선출.
    //ex) 요리게임. 맨위에 가장 늦게 설거지한 접시가 쌓이고, 이걸 먼저 써서 요리하게됨. 
    // Start is called before the first frame update
    void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("가나라다람");
        arrayList.Remove("가나라다람");
        arrayList.Add(5);
        arrayList.RemoveAt(3);
        arrayList.RemoveRange(1, 2); //1 인덱스로부터 2개를 지우겠다
        hashTable.Add("백만", 1000000); //키, 밸류 값을 같이 넣어주고 키값으로 찾는다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
