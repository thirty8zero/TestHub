using UnityEngine;
using System.Collections;

public class TurretMotion : MonoBehaviour 
{
    public GameObject bulletPrefab = null;
    public float rotateSpeed = 30;
    public float rotateSpeed2 = 30;
    public float shellForce = 100;
    public GameObject muzzleFlashPrefab;
    public Transform flashPos;
    //public Transform flashPos2;
    //public Transform flashPos3;
    public Transform barrel;
    //public Transform barrel2;
    //public Transform barrel3;





    void FixedUpdate () 
    {
        //rotate turret (change to rotate left and right on A and D keys respectively)
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed2, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(new Vector3(0, -Time.deltaTime * rotateSpeed2, 0));
        }

        //rotate barrel (clamp rotation on X axis to 30-90, there should be no rotation on the Y and Z axes)
        if (Input.GetKey(KeyCode.S))
        {
            barrel.transform.Rotate(new Vector3(Time.deltaTime * rotateSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            barrel.transform.Rotate(new Vector3(-Time.deltaTime * rotateSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
        //    barrel2.transform.Rotate(new Vector3(Time.deltaTime * rotateSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
        //    barrel2.transform.Rotate(new Vector3(-Time.deltaTime * rotateSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
         //   barrel3.transform.Rotate(new Vector3(Time.deltaTime * rotateSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
        //    barrel3.transform.Rotate(new Vector3(-Time.deltaTime * rotateSpeed, 0, 0));
        }

        //shoot bullet (change to shoot once per half-second)
        if (Input.GetMouseButtonDown(0))
        {
            //bullet prefab being spawned and given a force
            GameObject go = GameObject.Instantiate(bulletPrefab, barrel.transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<Rigidbody>().AddForce(barrel.transform.up * shellForce, ForceMode.Impulse);
            GameObject muzzleFlash = GameObject.Instantiate(muzzleFlashPrefab, flashPos.transform.position, barrel.transform.rotation) as GameObject;
            GameObject.Destroy(muzzleFlash, 1);
        

        

            //GameObject muzzleSpark = GameObject.Instantiate(muzzleSparkPrefab, flashPos.transform.position, transform.rotation) as GameObject;
            //GameObject.Destroy(muzzleSpark, 1);

            // GameObject go2 = GameObject.Instantiate(bulletPrefab, barrel2.transform.position, Quaternion.identity) as GameObject;
            // go2.GetComponent<Rigidbody>().AddForce(barrel2.transform.up * shellForce, ForceMode.Impulse);
            // GameObject muzzleFlash2 = GameObject.Instantiate(muzzleFlashPrefab, flashPos2.transform.position, barrel2.transform.rotation) as GameObject;
            // GameObject.Destroy(muzzleFlash2, 1);

            //  GameObject go3 = GameObject.Instantiate(bulletPrefab, barrel3.transform.position, Quaternion.identity) as GameObject;
            // go3.GetComponent<Rigidbody>().AddForce(barrel3.transform.up * shellForce, ForceMode.Impulse);
            // GameObject muzzleFlash3 = GameObject.Instantiate(muzzleFlashPrefab, flashPos3.transform.position, barrel3.transform.rotation) as GameObject;
            // GameObject.Destroy(muzzleFlash3, 1);
        }
    }
}
