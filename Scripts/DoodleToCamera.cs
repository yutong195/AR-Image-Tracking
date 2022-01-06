using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoodleToCamera : MonoBehaviour
{
    public void Doodle_Camera(string camera)
    {
        SceneManager.LoadScene(camera);
    }
}
