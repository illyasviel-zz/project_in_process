using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {
    GetPos getPos;
    NavMeshAgent nav;
    Animator ani;
    Vector3 startDes;

    bool newPlayer = true;

    //PlayerPrefs 
	
    // Use this for initialization
	void Start () {
        getPos = Camera.main.GetComponent<GetPos>();
        nav = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();

        ani.SetBool("isWalking", true);
        ani.speed = 5f;
        startDes = getPos.desPos;
        nav.SetDestination(startDes);
        nav.stoppingDistance = 0.0f;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
