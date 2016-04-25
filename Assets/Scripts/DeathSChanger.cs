using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathSChanger : MonoBehaviour {

    public void LoadStage()
    {
        SceneManager.LoadScene("Scenes/Main");
    }
}
