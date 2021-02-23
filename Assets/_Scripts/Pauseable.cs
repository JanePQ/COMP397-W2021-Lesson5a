using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Pauseable : MonoBehaviour
{

    public List<MonoBehaviour> scripts;
    public List<NavMeshAgent> agents;
    public bool isGamePaused;

    // Start is called before the first frame update
    void Start()
    {
        isGamePaused = false;
    }

    // Update is called once per frame
    public void TogglePause()
    {
        isGamePaused = !isGamePaused;

        foreach (var script in scripts)
        {
            script.enabled = !isGamePaused;
        }

        foreach (var agent in agents)
        {
            agent.enabled = !isGamePaused;
        }
    }
}
