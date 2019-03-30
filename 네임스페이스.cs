using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JH.Studio;

//네임스페이스 사용이유: 협업, 대형 프로젝트, 외부 라이브러리...


namespace JH
{

    public class Youtube
    {
        public int subscribe;
    }
    //클래스의 이름이 같으면 네임스페이스를 써서 분리한다.
    namespace Studio
    {
        public class Youtube
        {
            int like;
            public void SetLike(int value)
            {
                like = value;

            }
            public bool IsLike()
            {
                return like != 0;
            }
        }
    }
}
public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update


    Youtube jh=new Youtube();
    

    void Start()
    {
        //jh = new Youtube();
        jh.SetLike(5);
        print(jh.IsLike());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
