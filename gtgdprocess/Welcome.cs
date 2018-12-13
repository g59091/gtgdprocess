using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// "namescape" allows for multiple files of the same name
namespace Chp1
{
  public class Welcome : MonoBehaviour
  {

	  private string message = "Welcome";
		private Text textWelcome;
		public GameObject canvasWelcome;

		// Awake function put before Start()
		//void Awake(){}

		// Use this for initialization
		void Start()
    {
			SetInitialReferences();
      WelcomeMessage();
    }

    // Update is called once per frame
		/*
		void Update()
    {
				
    }
		*/

		void SetInitialReferences()
		{
			textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
		}

    void WelcomeMessage()
    {
			if (textWelcome != null)
				textWelcome.text = message;
			else 
				Debug.LogWarning("welcomeText not assigned.");

			// Invoke = timer function to delay another function ["function_string, time_float"]
			StartCoroutine(DisableCanvas(3.5f));
		}

		// IEnumerator used to suspend function with yield modifier
		IEnumerator DisableCanvas(float waitTime)
		{
			// Every float needs f at the end
			yield return new WaitForSeconds(waitTime);
			canvasWelcome.SetActive(false);
		}
  }

}

