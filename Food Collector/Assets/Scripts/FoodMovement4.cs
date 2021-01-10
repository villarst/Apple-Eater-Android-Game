using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement4 : MonoBehaviour
{

    public float speed = 5f;
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
            moveFoodRight();
        }
        if(!switc){
            moveFoodLeft();
        }
        if(transform.position.x >= -0.64){
            switc = false;
            spriteRenderer.flipX = true;
        }
        if(transform.position.x <= -2.31){
            switc = true;
            spriteRenderer.flipX = false;
        }
    }

    public void moveFoodRight(){
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void moveFoodLeft(){
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
