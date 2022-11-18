using UnityEngine;
using UnityEngine.UI;
using TMPro;


[RequireComponent (typeof (CountdownTimer))]
public class FadeAway : MonoBehaviour {
	private CountdownTimer countdownTimer;
	private TMP_Text textUI;

	// number of seconds before text completely fades away ...
	[SerializeField] int startSeconds = 5;

	//---------------------------------
	void Awake ()
	{
		// get reference to our screen text object & our scripted timer object
		textUI = GetComponent<TMP_Text>();	
		countdownTimer = GetComponent<CountdownTimer>();
	}

    void Start(){
		countdownTimer.ResetTimer(startSeconds);
	}

	//---------------------------------
	void Update ()
	{
		// get the time remaining as a float between 0.0 and 1.0
		float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
		print (alphaRemaining);
		Color c = textUI.color;

		// set alpha to our time remaining percentage
		// so 1.0 means full text color, and 0.5 means half transparent and so on..
		c.a = alphaRemaining;
		textUI.color = c;
	}
}
