private var RemoteIP : String = "127.0.0.1";
private var SendToPort : int = 3334;
public var ListenerPort : int = 1234;

private var handler : Osc;

public function Start () {
	var udp : UDPPacketIO = GetComponent("UDPPacketIO");
	udp.init(RemoteIP, SendToPort, ListenerPort);
	handler = GetComponent("Osc");
	handler.init(udp);
	
	// Examples
	handler.SetAddressHandler("/sayhello", UpdateSphere1);
	handler.SetAddressHandler("/sphere2", UpdateSphere2);
}

function Update () {
}	

public function UpdateSphere1(oscMessage : OscMessage) : void {
	var pressureSphere1 = oscMessage.Values[0];
	Debug.Log("Sphere1");
}

public function UpdateSphere2(oscMessage : OscMessage) : void {
	var pressureSphere2 = oscMessage.Values[0];
	Debug.Log("Sphere2");
}
