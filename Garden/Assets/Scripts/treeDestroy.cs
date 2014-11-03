using UnityEngine;
using System.Collections;

public class treeDestroy : MonoBehaviour {
	public Component lumberJack;
	
	
	
	void OnCollisionEnter (Collision col){
		lumberJack.tag = "tree";
		if (col.gameObject.tag == "tree"){
			Destroy(gameObject); // Not sure why I had to the script on the tree, and not on the lumberJack but this works
		}
		
	}
}