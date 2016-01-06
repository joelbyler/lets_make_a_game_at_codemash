//This script determines of the runner has landed on the turret power marker and powers the turret down 

using UnityEngine;
using UnityEngine.Analytics;

public class TurretPowerMarker : MonoBehaviour
{
	[SerializeField] TurretMovement turret;		//reference to the TurretMovement script on the turret

	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player")
			return;

		turret.TurnOff();
		Analytics.CustomEvent ("TurrentP Powered Down", null);
	}
}
