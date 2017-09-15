using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject primaryPosition;
    public GameObject primaryWeapon;

	// Use this for initialization
	void Start () {
        Instantiate(primaryWeapon, new Vector3(primaryPosition.transform.position.x, primaryPosition.transform.position.y, primaryPosition.transform.position.z), Quaternion.Euler(0,0,0), primaryPosition.transform);
		
	}
	
	// Update is called once per frame
	void Update () {
    }
}
