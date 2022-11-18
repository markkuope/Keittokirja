﻿using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValueToText : MonoBehaviour
{
	// referene to the UI slider GameObject that user will move
	public Slider sliderUI;

	// reference to the UI text display of slider current value
	private TMP_Text textSliderValue;

	//----------------------------
	// get reference to Text component and store in 'textSliderValue'
	void Awake()
	{
		textSliderValue = GetComponent<TMP_Text>();
	}

	//----------------------------
	// call function to update display - so as soon as scene starts we ensure correct
	// value is displayed
	void Start()
	{
		ShowSliderValue();
	}

	//-------------------------------
	// update the text display to show current slider value as a number
	// this method is called each time the Slider receives an OnValueChanged message
	public void ShowSliderValue ()
	{
		string sliderMessage = "Slider value = " + sliderUI.value;
		textSliderValue.text = sliderMessage;
	}
}
