using UnityEngine;
using System;
using System.Collections;

public class Cortana : MonoBehaviour
{
    public AudioClip clip1, clip2, clip3, clip4, clip5, clip6, clip7;
    private Animator animator;
    System.Random r = new System.Random();
    // Use this for initialization
    void Start ()
    {
        animator = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSelect()
    {
        int tmp = r.Next(1, 8);
        switch(tmp)
        {
            case 1:
                this.GetComponent<AudioSource>().clip = clip1;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
            case 2:
                this.GetComponent<AudioSource>().clip = clip2;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
            case 3:
                this.GetComponent<AudioSource>().clip = clip3;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
            case 4:
                this.GetComponent<AudioSource>().clip = clip4;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
            case 5:
                this.GetComponent<AudioSource>().clip = clip5;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
            case 6:
                this.GetComponent<AudioSource>().clip = clip6;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
            case 7:
                this.GetComponent<AudioSource>().clip = clip7;
                animator.SetTrigger("Talk");
                this.GetComponent<AudioSource>().Play();
                break;
        }
        //this.GetComponent<AudioSource>().Play();
    }
}
