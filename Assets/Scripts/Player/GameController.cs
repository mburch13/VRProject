using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public GameObject[] hazards;
//	public GameObject hazardBlue;
//	public GameObject hazardYellow;
//	public GameObject hazardPink;
	public int hazardCount;
	public Vector3 spawnValues;
//  public int hazardCountR;
	public float spawnWait;
	public float startWait;
	public float waveWait;
//	public Vector3 spawnValuesB;
//	public int hazardCountB;
//	public float spawnWaitB;
//	public float startWaitB;
//	public float waveWaitB;
//	public Vector3 spawnValuesY;
//	public int hazardCountY;
//	public float spawnWaitY;
//	public float startWaitY;
//	public float waveWaitY;
//	public Vector3 spawnValuesP;
//	public int hazardCountP;
//	public float spawnWaitP;
//	public float startWaitP;
//	public float waveWaitP;

    public GUIText scoreText;
    public int score;
    public GameObject spawnController;
    public Text countText;
    public Text RPS;
    public int rapidScore;
//    public GameObject RapidFireUI;

    //    public GameObject RPSmenu;

    void Start ()
	{

	}

    private void OnEnable()
    {
        Debug.Log("Enable Called");
        StartCoroutine(SpawnWaves());
        score = 0;
        UpdateScore();
        UpdateRPS();
        

        //		StartCoroutine (SpawnWavesB ());
        //		StartCoroutine (SpawnWavesY ());
        //		StartCoroutine (SpawnWavesP ());

    }

    //------------------------------------------------------------------------
    //RED!!!
    IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while(true)
		{
			for (int i = 0; i < hazardCount; i++) {
				GameObject hazard = hazards[Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range(1, spawnValues.y), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
        UpdateRPS();
    }

    void UpdateScore ()
    {
		countText.text = "" + score;
    }

    void UpdateRPS()
    {

        rapidScore = score % 100;

        if (rapidScore < 50)
        {
            RPS.text = "1 Lsr/Sec";
        }

        if (rapidScore >= 50 && rapidScore < 100)
        {
            RPS.text = "2 Lsr/Sec";
        }

        //if (rapidScore >= 100)
        //{
        //    RPS.text = "1 Lsr/Sec";
        //}
    }

}


//------------------------------------------------------------------------
//	//BLUE!!!
//	IEnumerator SpawnWavesB ()
//	{
//		yield return new WaitForSeconds (startWaitB);
//		while(true)
//		{
//			for (int i = 0; i < hazardCount; i++) {
//				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValuesB.x, spawnValuesB.x), Random.Range(1, spawnValuesB.y), spawnValuesB.z);
//				Quaternion spawnRotation = Quaternion.identity;
//				Instantiate (hazardBlue, spawnPosition, spawnRotation);
//				yield return new WaitForSeconds (spawnWaitB);
//			}
//			yield return new WaitForSeconds (waveWaitB);
//		}
//	}
////------------------------------------------------------------------------
//	//YELLOW!!!
//	IEnumerator SpawnWavesY ()
//	{
//		yield return new WaitForSeconds (startWaitY);
//		while(true)
//		{
//			for (int i = 0; i < hazardCount; i++) {
//				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValuesY.x, spawnValuesY.x), Random.Range(1, spawnValuesY.y), spawnValuesY.z);
//				Quaternion spawnRotation = Quaternion.identity;
//				Instantiate (hazardYellow, spawnPosition, spawnRotation);
//				yield return new WaitForSeconds (spawnWaitY);
//			}
//			yield return new WaitForSeconds (waveWaitY);
//		}
//	}
////------------------------------------------------------------------------
//	//PINK!!!
//	IEnumerator SpawnWavesP ()
//	{
//		yield return new WaitForSeconds (startWaitP);
//		while(true)
//		{
//			for (int i = 0; i < hazardCount; i++) {
//				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValuesP.x, spawnValuesP.x), Random.Range(1, spawnValuesY.y), spawnValuesP.z);
//				Quaternion spawnRotation = Quaternion.identity;
//				Instantiate (hazardPink, spawnPosition, spawnRotation);
//				yield return new WaitForSeconds (spawnWaitP);
//			}
//			yield return new WaitForSeconds (waveWaitP);
//		}
//	}
