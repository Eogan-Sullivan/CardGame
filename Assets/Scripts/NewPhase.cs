using UnityEngine;

public class NewPhase: MonoBehaviour
{

   
    public enum Phases { redDrawPhase, redMainPhase, blueDrawPhase, blueMainPhase, AttackPhase };
    public Phases currentPhase;
    GameObject deckManager;
    sqlTester myScript;
    Card card;

    // Use this for initialization
    void Start()
    {
        deckManager = GameObject.FindGameObjectWithTag("DeckManager");
        myScript = deckManager.GetComponent<sqlTester>();
        currentPhase = Phases.redDrawPhase;
    }

    // Update is called once per frame
    void Update()
    {

        {          
            switch (currentPhase)
            {
                case Phases.redDrawPhase:
                    GameObject.FindGameObjectWithTag("BlueGuys").GetComponent<blueHandReference>().disableBlueHand();
                    GameObject.FindGameObjectWithTag("RedGuys").GetComponent<redHandReference>().enableRedHand();
                    Debug.Log("Red Player Draw Phase");
                    card = myScript.pullCard();

                    myScript.createRedCard(card);
                    GameObject.FindGameObjectWithTag("RedMonsterZone").GetComponent<DropZone>().cardDraw = true;
                    currentPhase = Phases.redMainPhase;
                    break;

                case Phases.redMainPhase:
                    
                    Debug.Log("Red Player Main Phase");
                    break;


                case Phases.blueDrawPhase:
                    GameObject.FindGameObjectWithTag("RedGuys").GetComponent<redHandReference>().disableRedHand();
                    GameObject.FindGameObjectWithTag("BlueGuys").GetComponent<blueHandReference>().enableBlueHand();
                    Debug.Log("Blue Player Draw Phase");
                    card = myScript.pullCard();

                    myScript.createBlueCard(card);
                    GameObject.FindGameObjectWithTag("BlueMonsterZone").GetComponent<DropZone>().cardDraw = true;
                    currentPhase = Phases.blueMainPhase;
                    break;

                case Phases.blueMainPhase:
                    
                    Debug.Log("Blue Player Main Phase");
                    break;

                case Phases.AttackPhase:
                    Debug.Log("Attack Phase");
                    break;

                default:
                    Debug.Log("Nothing");
                    break;
            }
        }
    }



    public void nextPhase() {

        if (currentPhase == Phases.redMainPhase)
        {
            
            currentPhase = Phases.blueDrawPhase;
        }

        else if (currentPhase == Phases.blueMainPhase)
        {
            currentPhase = Phases.AttackPhase;
        }

        else if (currentPhase == Phases.AttackPhase)
        {
            currentPhase = Phases.redDrawPhase;
        }

        else
        {
            Debug.Log("Nothing");
        }
      
    }

    


    }


 

