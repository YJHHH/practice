using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamb2 : MonoBehaviour
{

    delegate void MyDelegate<T>(T a, T b);
    MyDelegate<int> myDelegate;
    // Start is called before the first frame update
    void Start()
    {
        myDelegate += (int a, int b) => print(a+b);
        myDelegate(3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
