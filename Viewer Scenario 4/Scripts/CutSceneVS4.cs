using System.Collections;
using UnityEngine;

public class CutSceneVS4 : MonoBehaviour
{


    public GameObject BlackTransition;

    public GameObject CutsceneParts;
    public GameObject Player;
    public GameObject ActualBatman;

    public CamInteractVS4 CamInteractScript;


    public void StartCutSceneVoid()
    {

        StartCoroutine(StartCutSceneCO());


    }


    IEnumerator StartCutSceneCO()
    {


        BlackTransition.SetActive(true);

        yield return new WaitForSeconds(1f);

        CutsceneParts.SetActive(true);
        Player.SetActive(false);
        ActualBatman.SetActive(false);

        yield return new WaitForSeconds(1.2f);

        BlackTransition.SetActive(false);

        yield return new WaitForSeconds(5.8f);

        BlackTransition.SetActive(true);

        yield return new WaitForSeconds(1f);

        Player.SetActive(true);
        ActualBatman.SetActive(true);
        CutsceneParts.SetActive(false);

        CamInteractScript.CanInteract = true;

        yield return new WaitForSeconds(1.2f);

        BlackTransition.SetActive(false);




    }


}
