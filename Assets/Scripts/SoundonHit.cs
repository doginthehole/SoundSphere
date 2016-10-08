using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundonHit : MonoBehaviour {
    public GameObject tag; 

    public AudioSource source;
    AudioSource audioS;
    // Use this for initialization
    void Start () {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
	    
	}
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == gameObject.tag)
        {
            source.Play();
        }
    }

}
