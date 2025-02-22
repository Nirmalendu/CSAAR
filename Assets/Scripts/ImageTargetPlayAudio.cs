﻿using UnityEngine;
using System.Collections;
using Vuforia;

public class ImageTargetPlayAudio : MonoBehaviour,ITrackableEventHandler
{
	public AudioSource a;
	    private TrackableBehaviour mTrackableBehaviour;

	    void Start()
	    {
		        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		        if (mTrackableBehaviour)
			        {
			            mTrackableBehaviour.RegisterTrackableEventHandler(this);
			        }
		    }
	     
	    public void OnTrackableStateChanged(
		                                    TrackableBehaviour.Status previousStatus,
		                                    TrackableBehaviour.Status newStatus)
	    {
		        if (newStatus == TrackableBehaviour.Status.DETECTED ||
			            newStatus == TrackableBehaviour.Status.TRACKED ||
			            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			        {
			            // Play audio when target is found
			            a.Play();
			        }
		        else
			        {
			            // Stop audio when target is lost
			            a.Stop();
			        }
		    }   
}