using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField] private GameObject follow;

	private void Update () {
		transform.position = new Vector3(follow.transform.position.x, follow.transform.position.y, this.transform.position.z);
	}
}
