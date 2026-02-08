using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Create a reference for the rigidbody2D in unity so it can be adjusted
    public Rigidbody2D myRigidBody;
    
    // Create a variable that adjusts the height of the "flap"
    // This will allow you change the values in unity
    public float flapStrength;

    public LogicScript logic;

    public bool deadBird = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        // Check if spacebar was pressed
        // GetKeyDown checks if pressed, GetKey checks if held
        if (Input.GetKeyDown(KeyCode.Space) && !deadBird)
        {
            // Add a vector to the physics object that makes it go up
            myRigidBody.linearVelocity = Vector2.up * flapStrength;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        deadBird = true;
    }

}
