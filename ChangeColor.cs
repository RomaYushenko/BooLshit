﻿using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public string[] names;
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
        GetComponent<BoxCollider2D>().enabled = false;
        gameObject.tag = "UnColor";
        CountClicker.click_count++;
        
    }
}
