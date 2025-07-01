using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnrate = 3;
    private float timer = 0;
    // Start is called before the first frame update
    public float heightOffset = 10; // Offset to adjust the height of the pipes
    
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
        void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;

        }

    }
    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;
        Instantiate(pipePrefab,new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
        
    }
}
