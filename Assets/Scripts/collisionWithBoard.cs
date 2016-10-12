using UnityEngine;
using System.Collections;

public class collisionWithBoard : MonoBehaviour {

    public Transform smoke;
    public AudioClip impact;
    AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Board")
        {
            Instantiate(smoke, this.transform.position, Quaternion.identity);
            this.GetComponent<Rigidbody>().isKinematic = true;
            audio.PlayOneShot(impact, 1.0f);
        }
    }
}
