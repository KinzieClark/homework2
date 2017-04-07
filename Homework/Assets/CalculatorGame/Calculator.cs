using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

	public InputField input1;
	public InputField input2;
	int number;
	float quotient;

	public void Addition () {

		number = int.Parse(input1.text) + int.Parse(input2.text);
		print(number);
	}
	public void Subtraction () {

		number = int.Parse(input1.text) - int.Parse(input2.text);
		print(number);
	}
	public void Division () {

		quotient = float.Parse(input1.text) / float.Parse(input2.text);
		print(quotient); 
	}
	public void Multiplication () {

		number = int.Parse(input1.text) * int.Parse(input2.text);
		print(number);
	}
}