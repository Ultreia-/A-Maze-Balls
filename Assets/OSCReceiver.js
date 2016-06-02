private var RemoteIP : String = "127.0.0.1";
private var SendToPort : int = 3334;
public var ListenerPort : int = 1234;

private var sizeSphere1 : String;
private var sizeSphere2 : String;

private var sphereScript : SphereSizeController;

private var handler : Osc;

public function Start () {

	sphereScript = GameObject.Find("SphereSizeControl").GetComponent("SphereSizeController"); 

	var udp : UDPPacketIO = GetComponent("UDPPacketIO");
	udp.init(RemoteIP, SendToPort, ListenerPort);
	handler = GetComponent("Osc");
	handler.init(udp);
	
	// Examples
	handler.SetAddressHandler("/sphere1", UpdateSphere1);
	handler.SetAddressHandler("/sphere2", UpdateSphere2);
}

function Update () {
}	

public function UpdateSphere1(oscMessage : OscMessage) : void {
	sizeSphere1 = oscMessage.Values[0];
	sphereScript.setSizeSphere1(sizeSphere1);
	Debug.Log(sizeSphere1);
}

public function UpdateSphere2(oscMessage : OscMessage) : void {
	sizeSphere2 = oscMessage.Values[0];
	sphereScript.setSizeSphere2(sizeSphere2);
	Debug.Log(sizeSphere2);
}
