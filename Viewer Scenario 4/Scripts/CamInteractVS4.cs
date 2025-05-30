using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CamInteractVS4 : MonoBehaviour
{


    public GameObject ActualBatman;
    public GameObject Player;

    public GameObject CutsceneParts;

    public Text InteractionText;

    public GameObject BlackTransition;

    public bool CanInteract = true;

    public GameObject RealCanister;
    public GameObject FakeCanister;

    private bool HaveCanister = false;

    public CutSceneVS4 CutSceneSCript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(CanInteract == true)
        {

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 5f))
            {


                if (hit.collider.CompareTag("Canister") && HaveCanister == false)
                {


                    InteractionText.text = "Take Fuel Canister";

                    if (Input.GetKeyDown(KeyCode.E))
                    {


                        RealCanister.SetActive(false);

                        InteractionText.text = "";

                        HaveCanister = true;

                    }


                }
                else if (hit.collider.CompareTag("PlacedOn") && HaveCanister == true)
                {


                    InteractionText.text = "Place The Fuel Canister";

                    if (Input.GetKeyDown(KeyCode.E))
                    {

                        CutSceneSCript.StartCutSceneVoid();

                        CanInteract = false;
                        InteractionText.text = "";
                        FakeCanister.SetActive(true);
                        HaveCanister = false;


                    }


                }
                else
                {


                    InteractionText.text = "";



                }



            }
            else
            {


                InteractionText.text = "";



            }




        }


        
    }


    


}
