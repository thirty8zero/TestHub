using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("AIE Scripts/GameDesignFoundations/Light Switch Button")]
public class LightSwitchButton : MonoBehaviour {

	GameObject mainCamera;
	bool PlayerInRange;
	public bool onePressOnly = true;
	//public GameObject ObjectToEnable;
	bool buttonAvailable = true;	
	//public GameObject DoorToAnimate;
	public List<GameObject> ObjectsToEnable = new List<GameObject>();
    public List<GameObject> ObjectsToDisable = new List<GameObject>();
    public List<GameObject> ObjectsToAnimate = new List<GameObject>();


    // Use this for initialization
    void Start () {
		//mainCamera = GameObject.FindWithTag ("MainCamera");
	
	}
	
	// Update is called once per frame
	void Update () {
        //print(buttonAvailable);
		if (PlayerInRange) {
			Press ();
		}
	}

	void Press ()
	{
        //Debug.Log("Press called");
		if (Input.GetKeyDown (KeyCode.E)) 
		{
            Debug.Log("E key pressed");
			int x = Screen.width / 2;
			int y = Screen.height / 2;
            //
            mainCamera = GameObject.FindWithTag("MainCamera");
            //
            Ray ray = mainCamera.GetComponent<Camera> ().ScreenPointToRay (new Vector3 (x, y));
			RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && (buttonAvailable))
            {
                Debug.Log("Have hit button");
                if (onePressOnly)
				{
					buttonAvailable = false;
					Debug.Log ("Button cannot be pressed again");
				}
					//gameObject.GetComponent<Animation> ().Play ();
					//
					//ObjectToEnable.SetActive (true);
					//DoorToAnimate.GetComponent<Animation> ().Play ();
					foreach (GameObject ObjectInAnimateList in ObjectsToAnimate) 
					{
						ObjectInAnimateList.GetComponent<Animation> ().Play ();						
					}
					foreach (GameObject ObjectInList in ObjectsToEnable) 
					{
						ObjectInList.SetActive (true);						
					}
                foreach (GameObject ObjectInList in ObjectsToDisable)
                {
                    ObjectInList.SetActive(false);
                   
                }
            }
					//
					//PLACE THINGS YOU WANT TO DO IN HERE
					//
					//
					//
				}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			Debug.Log ("Player is in push range of button");
			PlayerInRange = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			Debug.Log ("Player is outside push range of button");
			PlayerInRange = false;
		}
	}
}
