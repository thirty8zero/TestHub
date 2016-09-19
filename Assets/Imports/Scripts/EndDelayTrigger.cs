using UnityEngine;
using System.Collections;

public class EndDelayTrigger : MonoBehaviour
{

    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
	public GameObject screenFadeOut;
	public GameObject explosion0;
	public GameObject explosion1;
	public GameObject explosion2;

    // Use this for initialization
    void Start()
    {
        Invoke("Event1", 3.0f);
        Invoke("Event2", 6.0f);
        Invoke("Event3", 9.0f);
        Invoke("Event4", 12.0f);
        Invoke("Event5", 15.0f);
		Invoke("Event6", 18.0f);
		Invoke("Event7", 21.0f);
		Invoke("Event8", 24.0f);
		Invoke("Event9", 26.0f);
    }

    void Event1()
    {
		two.SetActive(true);
    }

    void Event2()
    {
		three.SetActive(true);
    }

    void Event3()
    {
		four.SetActive(true);
    }

    void Event4()
    {
		five.SetActive(true);
    }

    void Event5()
    {
		six.SetActive(true);
    }

	void Event6()
	{
		seven.SetActive(true);
	}

	void Event7()
	{
		eight.SetActive(true);
	}

	void Event8()
	{
		screenFadeOut.SetActive(false);
		explosion0.SetActive(true);
	}

	void Event9()
	{
		explosion1.SetActive(true);
		explosion2.SetActive(true);
	}
}
