using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salary : MonoBehaviour
{
    private int salary;
    /*
    private void SetSalary(int value) //salary 는 중요 변수이므로 private 선언.
    {
        salary = value; 
    }

    public int GetSalary() //타 클래스에서 salary 값 수정은 안되지만 불러올 수는 있다.
    {
        return salary; 
    }
    */
    private int bonus=10;
    //public int SalaryP { get { return salary; } private set { salary = value; } } //value는 예약어. 무조건 이걸로 해야한다.
    
    public int SalaryP { get { return salary+bonus; } set { if (value < 0) salary = 10; else salary = value; } }
    public int Bonus { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        salary = -5;
        //SalaryP = 10;
        print(SalaryP);
        Bonus = 10;
        print(Bonus);
        
    }
}

