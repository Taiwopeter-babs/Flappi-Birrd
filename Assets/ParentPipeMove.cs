using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPipeMove : MonoBehaviour
{
    public float MoveSpeed = 5;

    /// <summary>
    /// The zone at which the object is to be destroyed
    /// </summary>
    public float DeadZone = -45;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy gameObject holding this script
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }

        transform.position += MoveSpeed * Time.deltaTime * Vector3.left;
    }
}
