using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveFroce;
    public Rigidbody rb;

    void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");

        rb.AddForce(Vector3.right * xInput * moveFroce);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Main()
    {
        SceneManager.LoadScene("Main");
    }
}
