using UnityEngine;
using System.Collections;

public class heroClass : MonoBehaviour {

	public int health = 100;
	public int mana = 0;
	public int damage = 5;
	public Vector3 position;
	
	void OnMouseDown(){
		Debug.Log("WTF");
		rightClicked();
		Debug.Log ("" + leftButton.tapped);
		
	}
	void Update () {
		if (leftButton.tapped == true)
		{
			leftClicked();
			leftButton.tapped = false;
		}
		if (rightButton.tapped == true)
		{
			rightClicked();
			rightButton.tapped = false;
		}
		
	}
	void rightClicked(){
		Debug.Log("Right Clicked");
		position.Set (5, 0, 0);
		rigidbody2D.MovePosition(position);
	}
	public void leftClicked()
	{
		Debug.Log("Left Clicked");
		position.Set (-5, 0, 0);
		rigidbody2D.MovePosition(position);
		

	}
	void takeDamage(int damageDone){
		health = (health - damageDone);

	}
	void healDamage(int healthRestored){
		
		health = (health +healthRestored);
	
		
	}


}
