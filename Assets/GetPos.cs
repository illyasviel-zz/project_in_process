using UnityEngine;
using System.Collections;

public class GetPos : MonoBehaviour {

    Vector2 touchpos;
    public GameObject player;
    public Vector3 desPos;
    Vector3 generatePos;
	
	void Start()
    {
        generatePos = new Vector3(-17f, 11.9f, 25f);
    }
    // Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            touchpos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(touchpos);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
                Debug.Log(hit.point);
                if(hit.collider.name == "Floor")
                {
                    Instantiate(player, generatePos, Quaternion.identity);
                    desPos = hit.point;
                }
            }

        }

	}
}
