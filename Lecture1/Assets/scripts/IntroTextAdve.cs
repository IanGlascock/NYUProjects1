using UnityEngine;
using System.Collections;

public class IntroTextAdve : MonoBehaviour {

	string currentRoom = "Lobby"; // remembers our current location in world
	bool hasStudentID = false;


	void Update () {
		//if i delcare a variable inside Update (),
		// then i can only use this variable inside Update ()
		//also, a "buffer" is a staging area to prepare data

		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "Lobby") {
			//all your LOBBY code will go here later
			textBuffer += "\nYou see the Security guard.";
			//the line of code  is the SAME as the line of code above
			// textBuffer = textBuffer + "\nYOu see the NYUPoly security guard";
			textBuffer += "\npress [W] to go to Elevators";
			textBuffer += "\npress [S] to go Outside";

			if (Input.GetKeyDown (KeyCode.W) ) { // if player pushes W Key
				currentRoom = "Elevators";
			} else if ( Input.GetKeyDown (KeyCode.S) ) {
				currentRoom = "Outside";
			}
		} 

		else if (currentRoom == "Elevators") {
			//all your ELEVATOR code will go here later!
			textBuffer += "\n You are waiting.";
			//But which room will let the user set "hasStudentID to True?
			if ( hasStudentID == false ) {
				textBuffer += "\nYou can't go in without your Id card, though...";
			} else {
				textBuffer += "\nYou Swipe your student ID and the guard smiles.";
			}
		} 

		else if (currentRoom == "Outside") {
			// all your OUTSIDE code will go here
			textBuffer += "\nIt is really Hot, Why would you go outside?";
			textBuffer += "\npress [W] to go to the Lobby, LIke Right Now";
			if (hasStudentID == false) {
				textBuffer += "\n(oh hey you found your student ID on the floor!)";
				hasStudentID = true;
			} if ( Input.GetKeyDown (KeyCode.W) ) {
				currentRoom = "Lobby";
			}
		}
		// lets "render out" your text buffer and display it on screen
		//we  need to do this at the end otherwise we'll display text too soon
		GetComponent<TextMesh>().text = textBuffer;

	}
}
