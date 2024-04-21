using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    /// <summary>
    /// The prefabricated pipe gameobject
    /// </summary>
    public GameObject Pipe;

    // Number of seconds between spawn 
    public float SpawnRate = 3;

    private float Timer = 0;

    /// <summary>
    /// Offset for spawning heights
    /// </summary>
    public float HeightOffSet = 10;


    // Start is called before the first frame update
    void Start()
    {
        // load the start screen as the active scene
        // if the start game button is pressed, spawn pipes and start game
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // Interval between spawned pipes
        if (Timer < SpawnRate)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            Timer = 0;
        }
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - HeightOffSet;
        float highestPoint = transform.position.y + HeightOffSet;

        float randomPoint = Random.Range(lowestPoint, highestPoint);

        Instantiate(Pipe, new Vector3(transform.position.x, randomPoint, 0), transform.rotation);
    }
}
