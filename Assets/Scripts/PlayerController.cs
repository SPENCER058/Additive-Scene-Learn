using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float speed = 10f;

	private void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		transform.Translate(new Vector3(horizontal, 0, 0) * speed * Time.deltaTime);
	}
}
