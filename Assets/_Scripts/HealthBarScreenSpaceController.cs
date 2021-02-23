using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthBarScreenSpaceController : MonoBehaviour
{
    
    public Slider healthbarSlider;

    [Header ("Health Properties")]
    [Range(0, 100)]
    public int currentHealth =100;

    [Range(1, 100)]
    public int maximumHealth =100;

    public Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthbarSlider = GetComponent<Slider>();
        currentHealth = maximumHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void TakeDamage(int damage)
    {
        healthbarSlider.value -= damage;
        currentHealth -= damage;

        if (currentHealth < 0)
        {
            healthbarSlider.value = 0;
            currentHealth = 0;
        }
    }

    public void Reset()
    {
        healthbarSlider.value = maximumHealth;
        currentHealth = maximumHealth;
    }
}
