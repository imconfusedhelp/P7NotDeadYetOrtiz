using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    private int weaponSelected;
    private GameObject weapon;

    // Start is called before the first frame update
    void Start()
    {
        weaponSelected = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchWeapon();
        }
    }

    private void SwitchWeapon()
    {
        switch (weaponSelected)
        {
            case 1:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }
                weapon = Instantiate(Resources.Load("Prefabs/Pistol"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(0.1f, 0f, 0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = Vector3.one;
                weaponSelected += 1;
                break;

            case 2:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }
                weapon = Instantiate(Resources.Load("Prefabs/Shotgun"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(0.1f, 0f, 0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = Vector3.one;
                weaponSelected += 1;
                break;

            case 3:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }
                weapon = Instantiate(Resources.Load("Prefabs/LightningGun"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(0.1f, 0f, 0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = Vector3.one;
                weaponSelected += 1;
                break;
        }

        if (weaponSelected > 3)
        {
            weaponSelected = 1;
        }
    }
}
