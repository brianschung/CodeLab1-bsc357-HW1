using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		transform.position = new Vector2(Random.Range(-3,3), Random.Range(-3,3));
	}

}
