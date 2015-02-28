using UnityEngine;
using System.Collections;

public class MoveNaname : MonoBehaviour {

	// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
	// Do test the code! You usually need to change a few small bits.
	
	bool muki = true;		
	void  Update (){
		
		if (muki) 
		{
			transform.Translate(0.05f, 0, 0);
			//transform.Rotate(45, 90, 180);
			//transform.position.x += 0.05f;
			//transform.rotation.z = -0.45f;
		}
		else
		{
			transform.Translate(-0.05f, 0, 0);

		}
		
		if (transform.position.x > 7.75f)
		{
			muki = false;
		}
		if (transform.position.x < -7.75f)
		{
			muki = true;
		}
	}

}
