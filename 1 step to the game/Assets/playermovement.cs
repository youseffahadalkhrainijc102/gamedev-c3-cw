using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    //movement

   
    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("lv1");
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish") 
        {
            SceneManager.LoadScene("jumpscare");
        }
        else
        {

            SceneManager.LoadScene("lv2");
        }
    }

    void OnMouseDrag()
    {

        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = playerPos;



    }






    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        







    }
}
