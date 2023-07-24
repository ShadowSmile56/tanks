using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LooseScene : MonoBehaviour
{

    public void ToSampleScene()
    {
        SceneManager.LoadScene(1);
    }
}
