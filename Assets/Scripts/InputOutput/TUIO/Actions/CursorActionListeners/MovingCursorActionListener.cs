using UnityEngine;
using System.Collections;
using TUIO;

/**
 * Do not edit this file - instead see ExampleCustomMovingCursorActionsListener.cs
 * for an example on how to add custom code
 */
public class MovingCursorActionListener : CursorActionListener {
	public enum MovementAxis { NONE, X, Y, Z, XY, XZ, YX, YZ, ZX, ZY }
	public MovementAxis movementAxis = MovementAxis.XY;
	
	public float scalePositionX = 1f;
	public float scalePositionY = 1f;	
	
	public override void updateTuioCursor(TuioCursor c){
		transform.localPosition = getMoveVector(c);
	}
	
	protected Vector3 getMoveVector(TuioCursor o){		
		switch (movementAxis) {
			case MovementAxis.X : 
				return new Vector3(o.getX()*scalePositionX, transform.localPosition.y, transform.localPosition.z);
			case MovementAxis.Y : 
				return new Vector3(transform.localPosition.x, o.getX()*scalePositionX, transform.localPosition.z);
			case MovementAxis.Z : 
				return new Vector3(transform.localPosition.x, transform.localPosition.y, o.getX()*scalePositionX);
			case MovementAxis.XY : 
				return new Vector3(o.getX()*scalePositionX, o.getY()*scalePositionY, transform.localPosition.z);
			case MovementAxis.XZ : 
				return new Vector3(o.getX()*scalePositionX, transform.localPosition.y, o.getY()*scalePositionY);
			case MovementAxis.YX : 
				return new Vector3(o.getY()*scalePositionY, o.getX()*scalePositionX, transform.localPosition.z);
			case MovementAxis.YZ : 
				return new Vector3(transform.localPosition.x, o.getX()*scalePositionX, o.getY()*scalePositionY);
			case MovementAxis.ZX : 
				return new Vector3(o.getY()*scalePositionY, transform.localPosition.y, o.getX()*scalePositionX);
			case MovementAxis.ZY : 
				return new Vector3(transform.localPosition.x, o.getY()*scalePositionY, o.getX()*scalePositionX);
			case MovementAxis.NONE : 
			default : 
				return transform.localPosition;
		}
    }
}
