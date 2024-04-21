using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScoreTrigger : MonoBehaviour
{
    public ScoreLogic Logic;


    // Start is called before the first frame update
    void Start()
    {
        // gets a game object with tag `Logic` and references it at runtime with the class
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreLogic>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Bird layer is set to 3
        if (collision.gameObject.layer == 3)
        {
            Logic.AddScore(1);
        }
    }
}
