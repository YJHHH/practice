using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Record
{
    public int[] temp = new int[5];
    public int this[int index]
    {
        get {
            if (index >= temp.Length)
            {
                Debug.Log("인덱스가 너무 큽니다");
                return 0;
            }
            else
            { return temp[index]; }
        }
        set { if (index >= temp.Length) Debug.Log("인덱스가 너무 큽니다"); else temp[index] = value; }
    }
}
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    Record record = new Record();
    void Start()
    {
        record[3] = 5;
        record[5] = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
