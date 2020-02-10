using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovingScript : MonoBehaviour
{
    Rigidbody2D rbmovingwall;
    // Start is called before the first frame update
    void Start()
    {
        rbmovingwall = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbmovingwall.AddForce(Vector2.left * 5); 
    }
}
