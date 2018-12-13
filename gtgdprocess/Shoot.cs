using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chp1
{
	// Every function by default is private in C#
	public class Shoot : MonoBehaviour
	{

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			CheckForInput();
		}

		void CheckForInput() 
		{
			if (Input.GetKey(KeyCode.Mouse0))
			{
				Debug.Log("Key Pressed.");
			}
		}
	}

}

