using UnityEngine;
using System.Collections;

public class spwner : MonoBehaviour {

	public GameObject Box;
	[SerializeField]
	private GameObject _altbox;

    void awake()
    {

    }
	// Use this for initialization
	void Start () {
		GameObject _altbox = Resources.Load("Box") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Space")) {
			Instantiate (_altbox, this.transform.position, Quaternion.identity);	
		}
	}
}