﻿using UnityEngine;
using System.Collections;
using TUIO;

/**
 * Do not edit this file - instead see ExampleCustomMovingCursorActionsListener.cs
 * for an example on how to add custom code
 */
public class Moving3DCursorActionListener : Cursor3DActionListener {
	public float scalePositionX = 1f;
	public float scalePositionY = 1f;	
	public float scalePositionZ = 1f;	
	
	public override void updateTuioCursor(Tuio3DCursor c){
		transform.localPosition = getMoveVector(c);
	}
	
	protected Vector3 getMoveVector(Tuio3DCursor o){		
		return new Vector3(o.getX()*scalePositionX, o.getY()*scalePositionY, o.getZ()*scalePositionZ);
    }
}
