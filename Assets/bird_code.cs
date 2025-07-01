using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_code : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    // Start is called before the first frame update
    public logic_manager_script logic;
    public bool birdisAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_manager_script>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > Camera.main.orthographicSize || transform.position.y < -Camera.main.orthographicSize){
        logic.gameOver();
        birdisAlive = false;
    }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisAlive = false;
    }
}
