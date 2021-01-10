using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{

    public float speed = 1f;
    public bool switc = true;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(switc){
            moveFoodUp();
        }
        if(!switc){
            moveFoodDown();
        }
        if(transform.position.y >= -3.5){
            switc = false;
            spriteRenderer.flipY = true;
        }
        if(transform.position.y <= -4.3){
            switc = true;
            spriteRenderer.flipY = false;
        }
    }

    public void moveFoodUp(){
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    public void moveFoodDown(){
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
