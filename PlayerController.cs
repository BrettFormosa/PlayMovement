//"Simple code to move the player model, the Inputs are the default inputs in the Unity Engine"

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    //"Speed variable is changed via Unity Engine"

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
}
