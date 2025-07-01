using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;  

    void Start()
    {
        myRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * 6;
        }
    }

    void LateUpdate()
    {
        myRigidbody.angularVelocity = 0f;
        myRigidbody.rotation = 0f;
    }
}
