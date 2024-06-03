using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class setnavigationtargets : MonoBehaviour {

[SerializeField] 
private TMP_Dropdown navigationTargetDropDown;
[SerializeField]

private List<Target> navigationTargetObjects = new List<Target>();
private NavMeshPath path; // current calculated path
private LineRenderer line; // linerenderer to display path
private Vector3 targetPosition = Vector3.zero; // current target position

private static Vector3 currentPosition = Vector3.zero;

private bool lineToggle = false;

private void Start(){

path = new NavMeshPath();
line = transform.GetComponent<LineRenderer>();
line.enabled = lineToggle;
}
private void Update() {
    if (lineToggle && targetPosition != Vector3.zero) {
    NavMesh.CalculatePath (currentPosition, targetPosition, NavMesh.AllAreas, path);
    line.positionCount = path.corners.Length;
    line.SetPositions(path.corners);
    currentPosition = transform.position;

Debug.Log("Path Corners: " + path.corners.Length);
}
}

public void SetCurrentNavigationTarget (int selectedValue) {
    targetPosition = Vector3.zero;
    string selectedText = navigationTargetDropDown.options[selectedValue].text;
    Target currentTarget = navigationTargetObjects.Find(x => x.Name.Equals(selectedText));
    if (currentTarget != null) {
        targetPosition = currentTarget.PositionObject.transform.position;
}
}
public void ToggleVisibility() {
lineToggle = !lineToggle;
line.enabled = lineToggle;
}

 /* public void NavigateToQRCode(string qrCode)
    {
        Target qrTarget = navigationTargetObjects.Find(x => x.QRCode.Equals(qrCode));
        if (qrTarget != null)
        {
            targetPosition = qrTarget.PositionObject.transform.position;
        }
    }*/

    public void NavigateToQRCode(string qrCode) {
        Target qrTarget = navigationTargetObjects.Find(x => x.Name.Equals(qrCode));
        if (qrTarget != null) {
            targetPosition = qrTarget.PositionObject.transform.position;
            // Optionally, you can also update the dropdown or UI to reflect the change
        }
    
}
public static void UpdateCurrentPosition(Vector3 newPosition) {
    currentPosition = newPosition;
}
}