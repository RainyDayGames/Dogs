using UnityEngine;
using System.Collections;

public class SimpleAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 p1 = GameObject.Find("Player").transform.position;
		Vector3 p2 = this.transform.position;
		
		float a, b, distance;
        a = Mathf.Abs(p1.x - p2.x);
        b = Mathf.Abs(p1.z - p2.z);
		distance = Mathf.Sqrt((a * a) + (b * b));
		
		if(distance < 4 && distance > 1) {
			float px = GameObject.Find("Player").transform.position.x;
			float pz = GameObject.Find("Player").transform.position.z;
			
			float newX, newZ;
			
			if(px < p2.x) {
				newX = p2.x - (float)0.05;
			} else {
				newX = p2.x + (float)0.05;	
			}
			
			if(pz < p2.z) {
				newZ = p2.z - (float)0.05;
			} else {
				newZ = p2.z + (float)0.05;	
			}
			
			Vector3 vt = new Vector3(newX, 0, newZ);
			
			this.transform.position = vt;
		}
	}
}
