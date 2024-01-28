using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    public float m_Thrust = 12f;
    private int score;
    public TMP_Text scoreText;
    public float minYPosition = -3f;

    public GameObject gameOverSceen;
    
    public SpriteRenderer m_SpriteRenderer;
    
    [Header("Colours")]
    public Color _red,_skyblue,_purple,_yellow;

    void Start()
    {
        gameOverSceen.SetActive(false);
        
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = _red;
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update() 
    {
        scoreText.SetText("Score: "+score.ToString());
        
        if (transform.position.y < minYPosition)
        {
            StopFalling();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Red" && m_SpriteRenderer.color == _red)
        {
            score++;
        }
        
        else if(other.tag == "Purple" && m_SpriteRenderer.color == _purple )
        {
            score++;
        }
        else if(other.tag == "Yellow"  && m_SpriteRenderer.color == _yellow)
        { 
            score++;
        }
        else if(other.tag == "SkyBlue" && m_SpriteRenderer.color == _skyblue)
        {
            score++;
        }
        else if (other.tag == "Random")
        {
            
        }
        else
        {
          gameOverSceen.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump")|| Input.GetMouseButtonDown(0))
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
           // m_Rigidbody.velocity = Vector2.up * m_Thrust;
        }
    }
    
    void StopFalling()
    {
        m_Rigidbody.velocity = Vector3.zero;
        
        Vector3 newPosition = transform.position;
        newPosition.y = minYPosition;
        transform.position = newPosition;
    }
}
