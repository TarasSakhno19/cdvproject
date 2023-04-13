using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ 
    public Rigidbody2D rb2D;





    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range (-1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
