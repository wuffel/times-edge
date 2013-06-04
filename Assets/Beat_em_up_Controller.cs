using UnityEngine;
using System.Collections;

public class Beat_em_up_Controller : MonoBehaviour {
private CharacterController CharController;
	
public string CharacterOrientation;	
public float HorizontalSpeed;		
	
	
	// Use this for initialization
	void Start () {
     Debug.Log (transform.rotation.y);
	 CharController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	 
	//Nach Rechts	
		if(Input.GetAxis("Horizontal")>0)
		{
        	if(CharacterOrientation=="Left"){transform.Rotate(Vector3.up, 180); CharacterOrientation="Right";}
			CharController.Move(transform.forward * HorizontalSpeed * Time.deltaTime);
		}
	//Nach Links
		else if(Input.GetAxis("Horizontal")<0)
		{	
			if(CharacterOrientation=="Right"){transform.Rotate(Vector3.up, 180); CharacterOrientation="Left";}
			CharController.Move(transform.forward * HorizontalSpeed * Time.deltaTime);
			
		}
		
	}
}
