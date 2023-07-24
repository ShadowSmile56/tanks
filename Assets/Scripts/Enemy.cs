using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    private NavMeshAgent agent;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        if ((player.transform.position - agent.transform.position).sqrMagnitude < 10)
        {
            slider.value = slider.value - 10 * Time.deltaTime;
        }

        if (slider.value<=0) {
            SceneManager.LoadScene("LooseScene");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            Destroy(this.gameObject);
        }
    }
}
