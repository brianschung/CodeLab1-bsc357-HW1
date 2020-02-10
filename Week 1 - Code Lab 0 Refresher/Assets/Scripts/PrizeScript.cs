using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{

    private Rigidbody2D rb;

    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -80)
        {
            //transform.position = new Vector2(Random.Range(-3, 3), Random.Range(10,11));
            //rb = gameObject.GetComponent<Rigidbody2D>();
            //rb.velocity = new Vector2(0.0f, 0.0f);
            Instantiate(myPrefab, new Vector2(Random.Range(-3, 3), Random.Range(20, 22)), Quaternion.identity);
            Destroy(gameObject);
        }

    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            //gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            //transform.position = new Vector2(Random.Range(-3,3), Random.Range(20,22));
            Instantiate(myPrefab, new Vector2(Random.Range(-3, 3), Random.Range(20, 22)), Quaternion.identity);
            //Destroy(GetComponent<Rigidbody2D>());
            Destroy(gameObject);
            Model.score = Model.score + 1;
            //Debug.Log(Model.score);
        }

        if (collision.gameObject.tag == "DeathWall")
        {
            Instantiate(myPrefab, new Vector2(Random.Range(-3, 3), Random.Range(20, 22)), Quaternion.identity);
            Destroy(gameObject);

        }

    }

}
