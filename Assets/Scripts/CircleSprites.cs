using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CircleSprites : MonoBehaviour
{
    public GameObject GamePlayScreen;
    public GameObject GameOverScreen;
    public GameObject player;
    [Header("Cube 01")]
    public GameObject cube1;
    public int rotationAngle01;
    
    
    [Header("Cube 02")]
    public GameObject cube2;
    public int rotationAngle02;
    
    
    [Header("Cube 03")]
    public GameObject cube3;
    public int rotationAngle03;
    

    private void Update()
    {
        cube1.transform.Rotate(0f, 0f, rotationAngle01 * Time.deltaTime);
        cube2.transform.Rotate(0f, 0f, rotationAngle02 * Time.deltaTime);
        cube3.transform.Rotate(0f, 0f, rotationAngle03 * Time.deltaTime);
    }


    public void Restart()
    {
        GamePlayScreen.SetActive(true);
        GameOverScreen.SetActive(false);
        player.transform.position =new Vector3(0, -3f,0);
    }


}
