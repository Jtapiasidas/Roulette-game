using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulette : MonoBehaviour {

	public float speed = 0;
    public float maxSpeed = 20;
    public float minSpeed = 5;
	public float stopSpeed = 0.1f; 

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		//transform.rotation += new Vector3(0, 0, 1);+
		if (speed > 0){
			transform.Rotate (0,0,speed);
			speed -= stopSpeed; //speed = speed - stopSpeed;

			if(speed <= 0) {	
				
				SectorCheck(transform.rotation.eulerAngles.z);

			}
		}
	}			

    public void StartSpinning()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

	public void Spin(float speed)	{
		this.speed = speed; 
	}

	public void SectorCheck(float rotation) {	
		//float angleZ = Mathf.Round(transform.rotation.eulerAngles.z, 360.0f);
		if ( rotation < 90 && rotation > -90 ){
			Debug.Log("you are in the rigth side, bitch");
		}else{
			Debug.Log("you are in the left side, bitch");
		}
		
	}

}
