using UnityEngine;
using System.Collections;

public class WandController : MonoBehaviour {
    private SteamVR_TrackedObject trackedObj;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    public GameObject fireTransform;
    private GameObject instantiatedFireTransform;
    private bool triggerPressed = false;
    private bool triggerUnpressed = false;
    // Use this for initialization
    void Start () {
       
         trackedObj = GetComponent<SteamVR_TrackedObject>();
        instantiatedFireTransform = Instantiate(fireTransform, transform.position, Quaternion.Euler(transform.rotation.eulerAngles.x + 55.25f, transform.rotation.eulerAngles.y +193.17f, transform.rotation.eulerAngles.z+6.09f)) as GameObject;
        instantiatedFireTransform.transform.position = new Vector3(transform.position.x + .015f, transform.position.y - .127f, transform.position.z + .137f);
        instantiatedFireTransform.transform.SetParent(transform);
    }
	
	// Update is called once per frame
	void Update () {
        
        triggerPressed= controller.GetPress(triggerButton);
        triggerUnpressed = controller.GetPressUp(triggerButton);
        if (triggerPressed)
        {
            instantiatedFireTransform.SetActive(true);
     
        }
        if (triggerUnpressed)
        {
            instantiatedFireTransform.SetActive(false);
        }
    }
}
