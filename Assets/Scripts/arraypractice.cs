using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraypractice : MonoBehaviour
{
    public int[] LottoNumber = { 1, 2, 3, 4, 5, 6 };
    public int myNumber;
    // Start is called before the first frame update
    void Start()
    {
        myNumber = LottoNumber[Random.Range(0,5)];
        Debug.Log("My Lotto Number is:" + myNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
