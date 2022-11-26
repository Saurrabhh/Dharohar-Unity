using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
