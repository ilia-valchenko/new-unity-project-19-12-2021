using UnityEngine;

public class HelicopterBlades : MonoBehaviour
{
    private const float yRotationChange = (float)1800;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(transform.rotation.x, yRotationChange * Time.deltaTime, transform.rotation.z));
    }
}
