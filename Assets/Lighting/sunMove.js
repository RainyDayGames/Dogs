#pragma strict

var distance : float = 0;
var duration : float = 60.0;

function Start () {
}



function Update() {
	// argument for cosine
	var phi : float = Time.time / duration * 2 * Mathf.PI;
	// get cosine and transform from -1..1 to 0..1 range
	var amplitude : float = Mathf.Cos( phi ) * 0.5 + 0.5;
	
	transform.rotation.x = GameObject.Find('Player').transform.position.x;
	transform.rotation.y = GameObject.Find('Player').transform.position.y;
	transform.rotation.z = GameObject.Find('Player').transform.position.z;
}