using UnityEngine;
using System.Collections;

public class Cortana : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSelect()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
