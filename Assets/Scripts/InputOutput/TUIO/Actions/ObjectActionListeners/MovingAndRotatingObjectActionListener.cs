using UnityEngine;
using System.Collections;
using TUIO;

/**
 * Do not edit this file - instead see ExampleCustomMovingObjectActionsListener.cs
 * for an example on how to add custom code
 */
public class MovingAndRotatingObjectActionListener : ObjectActionListener {
	public enum MovementAxis { NONE, X, Y, Z, XY, XZ, YX, YZ, ZX, ZY }
	public MovementAxis movementAxis = MovementAxis.XY;
	public enum RotationAxis { NONE, X, REVX, Y, REVY, Z, REVZ }
	public RotationAxis rotationAxis = RotationAxis.X;

	public float scalePositionX = 1f;
	public float scalePositionY = 1f;
	
    public float offsetX = 0f;
    public float offsetY = 0f;

	public override void updateTuioObject(TuioObject o){
		transform.localPosition = getMoveVector(o);
		transform.localRotation = getRotationQuaternion(o);
	}
	
	protected Vector3 getMoveVector(TuioObject o){		
		switch (movementAxis) {
			case MovementAxis.X : 
				return new Vector3(o.getX()*scalePositionX+offsetX, transform.localPosition.y, transform.localPosition.z);
			case MovementAxis.Y : 
				return new Vector3(transform.localPosition.x, o.getX()*scalePositionX+offsetX, transform.localPosition.z);
			case MovementAxis.Z : 
				return new Vector3(transform.localPosition.x, transform.localPosition.y, o.getX()*scalePositionX+offsetX);
			case MovementAxis.XY : 
				return new Vector3(o.getX()*scalePositionX+offsetX, o.getY()*scalePositionY+offsetY, transform.localPosition.z);
			case MovementAxis.XZ : 
				return new Vector3(o.getX()*scalePositionX+offsetX, transform.localPosition.y, o.getY()*scalePositionY+offsetY);
			case MovementAxis.YX : 
				return new Vector3(o.getY()*scalePositionY+offsetY, o.getX()*scalePositionX+offsetX, transform.localPosition.z);
			case MovementAxis.YZ : 
				return new Vector3(transform.localPosition.x, o.getX()*scalePositionX+offsetX, o.getY()*scalePositionY+offsetY);
			case MovementAxis.ZX : 
				return new Vector3(o.getY()*scalePositionY+offsetY, transform.localPosition.y, o.getX()*scalePositionX+offsetX);
			case MovementAxis.ZY : 
				return new Vector3(transform.localPosition.x, o.getY()*scalePositionY+offsetY, o.getX()*scalePositionX+offsetX);
			case MovementAxis.NONE : 
			default : 
				return transform.localPosition;
		}
    }

	protected Quaternion getRotationQuaternion(TuioObject o){
		float angleDegrees = o.getAngleDegrees();
        switch (rotationAxis){
            case RotationAxis.X:
                return Quaternion.AngleAxis(angleDegrees, Vector3.right);
            case RotationAxis.Y:
                return Quaternion.AngleAxis(angleDegrees, Vector3.up);
           case RotationAxis.Z:
                return Quaternion.AngleAxis(angleDegrees, Vector3.forward);
            case RotationAxis.REVX:
                return Quaternion.AngleAxis(-angleDegrees, Vector3.right);
            case RotationAxis.REVY:
                return Quaternion.AngleAxis(-angleDegrees, Vector3.up);
           case RotationAxis.REVZ:
                return Quaternion.AngleAxis(-angleDegrees, Vector3.forward);
			case RotationAxis.NONE:
			default:
				return transform.localRotation;
        }
    }
}
