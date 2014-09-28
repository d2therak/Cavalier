#pragma strict

function OnMouseDown(){
Debug.Log("WTF");
rightClicked();

}
public function rightClicked()
{
Debug.Log("Right Clicked");
//Transform.translate(Vector3(1,0,0));
}
public function leftClicked()
{
Debug.Log("Left Clicked");
}