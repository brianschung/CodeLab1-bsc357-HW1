using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Model : MonoBehaviour
{

    public static int score=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the text to the score
        //GetComponent<TextMesh>().text = score.ToString();
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

        // press R to restart
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
