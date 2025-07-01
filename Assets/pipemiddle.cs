using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    // Start is called before the first frame update
    public logic_manager_script logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_manager_script>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
