using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laserpoint : MonoBehaviour {

	private SteamVR_TrackedObject trackedObj;

	public GameObject laserPrefabs;
	private GameObject laser;
	private Transform laserTransform;
	private Vector3 hitPoint;

	public SteamVR_Controller.Device controller
	{
		get
		{
			return SteamVR_Controller.Input((int)GetComponent<SteamVR_TrackedObject>().index);
		}//CONTROLLER에 쉽게 접근하기 위해 추적한 오브젝트의 인덱스를 사용하여 Controller의 입력으로 전달
	}

	void Awake()
	{
		trackedObj=GetComponent<SteamVR_TrackedObject>();
	}

	private void ShowLaser(RaycastHit hit)
	{
		laser.SetActive(true);
		laserTransform.position=Vector3.Lerp(trackedObj.transform.position,hitPoint,.5f);
		laserTransform.LookAt(hitPoint);
		laserTransform.localScale=new Vector3(laserTransform.localScale.x,laserTransform.localScale.y,hit.distance);
	}



	void Start()
	{
		laser = Instantiate(laserPrefabs);
		laserTransform = laser.transform;
	}


	// Update is called once per frame
	void Update () {
		//if(controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
		//{
			RaycastHit hit;
			/*if (Physics.Raycast(trackedObj.transform.position,transform.forward,out hit,100,teleportMask))
			{
				hitPoint=hit.point;
				ShowLaser(hit);
				reticle.SetActive(true);
				teleportReticleTransform.position=hitPoint+teleportReticleOffset;
				shouldTeleport=true;
			}*/
			if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 100))
			{
				hitPoint = hit.point;
				ShowLaser(hit);
			}
			//else
			//{
				//laser.SetActive(false);
				//reticle.SetActive(false);
			//}
			//if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad)&&shouldTeleport)
			//{
			//	Teleport();
			//}

		//}
	}}
