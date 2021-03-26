using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SportButton : MonoBehaviour
{
    public Sprite[] images;
   Image sportButton;
    private void Start()
    {
        sportButton = GetComponent<Image>();
        sportButton.sprite = images[Random.Range(0, images.Length)];
    }
    public void EscapeFromGame()
    {
            Application.Quit();
    }
}

