using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movinabout : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, moveVertical, 0.0f);

        rb.AddForce(movement * speed);
    }
}
