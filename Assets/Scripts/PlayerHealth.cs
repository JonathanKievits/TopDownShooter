using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float max_health = 100f;
    public float curr_health = 0f;
    public GameObject Healthbar;

    void Start()
    {
        curr_health = max_health;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Invoke("DMGE", 0.1f);
        }
        if (other.CompareTag("HPUP"))
        {
            if (curr_health < 100)
            {
                curr_health += 10;
            }
        }
    }
    void Update()
    {
        float Calc_Health = curr_health / max_health;
        SetHealthBar(Calc_Health);
        if (curr_health <= 1)
        {
            LoadStage();
        }
    }

    void DMGE()
    {
        curr_health -= 20f;
    }

    public void SetHealthBar(float myHealth)
    {
        Healthbar.transform.localScale = new Vector3(myHealth, Healthbar.transform.localScale.y, Healthbar.transform.localScale.z);
    }
    public void LoadStage()
    {
        SceneManager.LoadScene("Scenes/Death");
    }
}
