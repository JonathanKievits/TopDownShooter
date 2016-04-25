using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float max_health = 100f;
    public float curr_health = 0f;
    public GameObject Healthbar;

    void Start()
    {
        curr_health = max_health;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Invoke("DMGE", 0.1f);
        }
    }
    void Update()
    {
        if (curr_health <= 1)
        {
            Destroy(gameObject);
        }
        float Calc_Health = curr_health / max_health;
        SetHealthBar(Calc_Health);
    }
    public void SetHealthBar(float myHealth)
    {
        Healthbar.transform.localScale = new Vector3(myHealth, Healthbar.transform.localScale.y, Healthbar.transform.localScale.z);
    }

    void DMGE()
    {
        curr_health -= 50f;
    }
}
