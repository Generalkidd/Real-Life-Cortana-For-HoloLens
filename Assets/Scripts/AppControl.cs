using UnityEngine;
using System.Collections;

public class AppControl : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnSwitch()
    {
        Destroy(GameObject.Find("Cortana 2"));
        GameObject c = (GameObject)Instantiate(GameObject.Find("Cortana 1"), new Vector3(0, -0.5f, 1.549f), new Quaternion(0, 180, 0, 0));
    }
}
