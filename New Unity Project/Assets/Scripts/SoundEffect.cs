using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp
{
	public class EmptyClass: MonoBehaviour
	{
		public object AudioSource;
		void Update()
		{ 
			// If the left mouse button is pressed down...
			if(Input.GetMouseButtonDown(0) == true)
			{
				GetComponent<AudioSource>().Play();
			} 
		}
	}
}

