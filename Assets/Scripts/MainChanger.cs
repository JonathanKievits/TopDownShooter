using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainChanger : MonoBehaviour
{

    public void LoadStage()
    {
        SceneManager.LoadScene("Scenes/Main");
    }
}
