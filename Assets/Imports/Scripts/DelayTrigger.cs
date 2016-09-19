using UnityEngine;
using System.Collections;

public class DelayTrigger : MonoBehaviour {

    /*float countdownTimer = 45;
    float countdownTimer2 = 37;
    float countdownTimer3 = 11;
    float countdownTimer4 = 35;*/

    public GameObject cutscenecamera;
    public GameObject startCamera;
    public GameObject player;
    public GameObject whiteFlash;
    public GameObject heartBeat;
    public GameObject openingVO;
    public GameObject fadeCanvas;

	// Use this for initialization
	void Start () {
        Invoke("Event1", 11.0f);
        Invoke("Event2", 35.0f);
        Invoke("Event3", 37.0f);
        Invoke("Event4", 45.0f);
	}

    void Event1()
    {
        openingVO.SetActive(true);
    }

    void Event2()
    {
        fadeCanvas.SetActive(true);
    }

    void Event3()
    {
        cutscenecamera.SetActive(true);
        startCamera.SetActive(false);
    }

    void Event4()
    {
        player.SetActive(true);
        cutscenecamera.SetActive(false);
        whiteFlash.SetActive(true);
        heartBeat.SetActive(true);
    }
	
	// Update is called once per frame
	/*void Update () {
        
        countdownTimer -= Time.deltaTime;
        countdownTimer2 -= Time.deltaTime;
        countdownTimer3 -= Time.deltaTime;
        countdownTimer4 -= Time.deltaTime;
        if (countdownTimer <= 0)
        {
            player.SetActive(true);
            cutscenecamera.SetActive(false);
            whiteFlash.SetActive(true);
            heartBeat.SetActive(true);
        }
        if (countdownTimer2 <= 0)
        {
            cutscenecamera.SetActive(true);
            startCamera.SetActive(false);
        }
        if (countdownTimer3 <= 0)
        {
            openingVO.SetActive(true);
        }
        if (countdownTimer4 <= 0)
        {
            fadeCanvas.SetActive(true);
        }
    }*/
}
