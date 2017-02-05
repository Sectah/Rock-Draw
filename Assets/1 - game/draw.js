#pragma strict

var rock : GameObject;
var ray : Ray;
var stopLilyRay : Ray;
var stopLilyHit : RaycastHit;
var hit : RaycastHit;
var objectPos : Vector3;
var pause : boolean;
var delay : float;
var item : String;

function Start () {
	pause = false;
}

function Update () {
	stopLilyRay = GetComponent.<Camera>().ScreenPointToRay(Input.mousePosition);
	if (Physics.Raycast(stopLilyRay, stopLilyHit)){
		item = stopLilyHit.collider.name;
	}
	//print(item);
	Spawn();
}

function Spawn () {
if (Input.mousePosition.y > 39.0f){
//print (Input.mousePosition.y);
if (item == "drawerPlane"){
	if (Input.GetMouseButtonDown(0)){
		
		ray = GetComponent.<Camera>().ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, hit)){
			objectPos = hit.point;
		}
		if (pause == false){
			
				objectPos = new Vector3(objectPos.x, objectPos.y, -8.27);
				Instantiate(rock, objectPos, Quaternion.identity);
				pause = true;
				yield WaitForSeconds(delay);
				pause = false;
			}
		}
	}
	}
}