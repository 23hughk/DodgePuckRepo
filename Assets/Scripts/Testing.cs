using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public float speed;
    public float xrange;
    public float yrange;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void LateUpdate()
    {
        if (transform.position.x > xrange)
        {
            transform.position = new Vector2(xrange, transform.position.y);
        
        }

        if(transform.position.x < -xrange)
        {
            transform.position = new Vector2(-xrange, transform.position.y);
        }

        if (transform.position.x > xrange)
        {
            transform.position = new Vector2(transform.position.x, yrange);

        }

        if (transform.position.x > xrange)
        {
            transform.position = new Vector2(xrange, transform.position.y);
        }

    // Update is called once per frame
    void Update()
    {
      
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal);

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal,moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);

        
    }
}