using Unity.VisualScripting;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    // Create a variable to reference another script
    public BirdScript script;

    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        // Connect variable with component "BirdScript" in Game Object with tag "Bird
        script = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Reference variable "deadBird" from component "BirdScript" in game object tagged as "Bird"
        // Now score will not be added after a game over
        if (collision.gameObject.tag == "Player" && !script.deadBird)
        {
            logic.addScore(1);

        }
    }
}
