using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
	
	public float force;
	Rigidbody2D rb;
	
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world.");
		rb = GetComponent<Rigidbody2D>();
		
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("");
		

		if (Input.GetKey(KeyCode.Space)) // if Space is pressed
		{
			rb.velocity = new Vector2(0,0);
			//rb.AddForce(Vector2.down * force); 
		}
		else
		{
			if (Input.GetKey(KeyCode.W)) // if W is pressed
			{
				rb.AddForce(Vector2.up * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.A)) // if A is pressed
			{
				rb.AddForce(Vector2.left * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.D)) // if D is pressed
			{
				rb.AddForce(Vector2.right * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.S)) // if S is pressed
			{
				rb.AddForce(Vector2.down * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.R))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
	}
}
