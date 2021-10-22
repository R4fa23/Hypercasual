using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdool : MonoBehaviour
{
    [SerializeField] LivroEstante livros;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {    
        
        rb.velocity = new Vector2(0,1);      
     
    }
}
