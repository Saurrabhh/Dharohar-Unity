using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPointer : MonoBehaviour
{
    Image image;
    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void onClick()
    {
        
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        Debug.Log("Presssedddddddddd");
    }
}
