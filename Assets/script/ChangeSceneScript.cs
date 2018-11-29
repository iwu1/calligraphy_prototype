using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour {

    public void changeScene()
    {
        SceneManager.LoadScene("calligraphy_scene");
    }
}
