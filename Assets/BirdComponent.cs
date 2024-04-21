using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdComponent : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float birdFlapStrength;
    public ScoreLogic Logic;

    // public StartSceneLogic StartSceneLogic;
    public bool BirdIsActive = true;

    public GameObject GameOverScreen;


    // Start is called before the first frame update
    public void Start()
    {
        // gets a game object with tag `Logic` and references it at runtime with the class
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreLogic>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdIsActive)
            myRigidBody.velocity = Vector2.up * birdFlapStrength;

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            EndGameAndResetScore();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        EndGameAndResetScore();
    }

    private void EndGameAndResetScore()
    {
        Logic.GameOver();
        BirdIsActive = false;
    }
}
