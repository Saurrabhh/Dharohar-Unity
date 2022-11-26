using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMap : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene((int)Scenes.MapPointer);
    }
}
