using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

//public List<string> cars;

	//void Start () {
	//	for (int i = 0; i < cars.Count; i++) //lists have count instead of length
	//	{
	//		print (cars [i]);
	//	}
	//}

//	public List<string> flowers;

//	void Start () {
//		for (int i = 3; i < flowers.Count; i++)
//		{
//			print ("Your garden is growing!");
//		}	
//	}		

	public int number = 0;

//	public void Start () {
//		for (int x = 0; x < 15; x+= 7)
//		{
//			print (x);
//		}	
//	}

//	void Start () {
//		for (int x = 2; x < 21; x += 2)
//			{
//				print (x);
//			}
//	}	

	void Start () {
		for (; number < 84;)
			{
				print(number +=10);
			}
	}	
}