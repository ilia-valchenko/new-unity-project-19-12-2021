using UnityEngine;

public class HelicopterFlying : MonoBehaviour
{
    private const float xPositionChange = (float)0.03;
    private const float zPositionChange = (float)-0.03;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //var xValue = transform.position.x + xPositionChange * Time.deltaTime;
        //var zValue = transform.position.z + zPositionChange * Time.deltaTime;

        transform.position = new Vector3(
            transform.position.x + xPositionChange,
            transform.position.y,
            transform.position.z + zPositionChange);

        //transform.position.Set(
        //    transform.position.x + xPositionChange * Time.deltaTime,
        //    transform.position.y * Time.deltaTime,
        //    transform.position.z + zPositionChange * Time.deltaTime);
    }
}
