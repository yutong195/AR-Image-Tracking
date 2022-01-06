using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDoodle : MonoBehaviour
{
    public void ClickToDoodle(string doodle)
    {
        SceneManager.LoadScene(doodle);
    }
}
