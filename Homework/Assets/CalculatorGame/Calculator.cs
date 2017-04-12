using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

	public InputField input1;
	public InputField input2;
	public Text result;
	int number;
	float quotient;

	public void Addition () {
		number = int.Parse(input1.text) + int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Subtraction () {
		number = int.Parse(input1.text) - int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Division () {
		quotient = float.Parse(input1.text) / float.Parse(input2.text);
		print(quotient); 
		result.text = quotient.ToString();
	}
	public void Multiplication () {
		number = int.Parse(input1.text) * int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Button0 () {
		print(0);
}
	public void Button1 () {
		print(1);
	}
	public void Button2 () {
		print(2);
	}
	public void Button3 () {
		print(3);
	}
	public void Button4 () {
		print(4);
	}
	public void Button5 () {
		print(5);
	}
	public void Button6 () {
		print(6);
	}
	public void Button7 () {
		print(7);
	}
	public void Button8 () {
		print(8);
	}
	public void Button9 () {
		print(9);
	}
}