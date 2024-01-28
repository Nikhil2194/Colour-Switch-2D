using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColourRandomiser : MonoBehaviour
{
   public GameObject player;
   public Color[] colours;
   private SpriteRenderer playerSprite;


   private void Start()
   {
      playerSprite = player.GetComponent<SpriteRenderer>();
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         int index = Random.Range(0, colours.Length);
         playerSprite.color = colours[index];
         Destroy(this.gameObject);
      }
   }
}
