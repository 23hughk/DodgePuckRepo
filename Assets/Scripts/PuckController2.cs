using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController2 : MonoBehaviour
{
    public int[] direction = { 0, 1, 2, 3 };
    public int moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = direction[Random.Range(0, 4)];
        Debug.Log("moveDirection = " + movedirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
