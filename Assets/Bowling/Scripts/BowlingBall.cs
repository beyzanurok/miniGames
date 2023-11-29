using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BowlingBall : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float leftBorder;
    public float rightBorder;
    public float moveIncrement;

   

    public void Bowl()
    {
        rb.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Main()
    {
        SceneManager.LoadScene("Main");
    }

    public void MoveLeft()
    {
        if (transform.position.x > rightBorder)
        {
            transform.position += new Vector3(-moveIncrement, 0, 0);
        }
    }

    public void MoveRight()
    {
        if (transform.position.x < leftBorder)
        {
            transform.position += new Vector3(moveIncrement, 0, 0);
        }
    }
}
