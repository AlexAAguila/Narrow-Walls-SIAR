/*REFERENCE https://www.youtube.com/watch?v=0KqwmcQqg0s 
 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class AudioPair : MonoBehaviour {

    AudioSource _audioSource;

    //get spectruum data for this array
    public float[] _samples = new float[512]; //20,000 hertz sample rate
	// Use this for initialization
	void Start () {
        _audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();	
	}

    void GetSpectrumAudioSource() {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman); //reduce leakage of spectrum data
    }

}
