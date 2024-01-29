using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.UI;
public class ChallengeLayout : MonoBehaviour
{

    public static ChallengeLayout challengeLayout;

    public GameObject source;
    public GameObject itemHolderPrefab;
    public Transform grid;

    public List<GameObject> holderList;
    public List<Challenge> challengeList;

    public List<Challenge> dailyChallenges = new List<Challenge>();
    public List<Challenge> bookChallenges = new List<Challenge>();


    // Start is called before the first frame update
    void Start()
    {
        challengeLayout = this;
        holderList = new List<GameObject>();

        //fills an array with everysingle challenge in the game
        dailyChallenges.Add(new Challenge(0, "Play Date", "Interact with any of your pet by pressing the \"Play\" button", false, "3 grapes"));
        dailyChallenges.Add(new Challenge(1, "Warm-Up", "Read 25 pages of any Book", false, "2 chicken legs"));
        dailyChallenges.Add(new Challenge(2, "Staying Informed", "Check out the \"News\" page", false, "2 soaps"));
        dailyChallenges.Add(new Challenge(3, "Fashion Genius", "Purchase anything from the Store", false, "3 chicken legs"));
        dailyChallenges.Add(new Challenge(4, "Knowledge is power", "Add a book", false, "5 grapes"));
        bookChallenges.Add(new Challenge(0, "Getting Started", "Finish reading 25% of any book", false, "5 soaps"));
        bookChallenges.Add(new Challenge(1, "We're getting there", "Finish reading 50% of any book", false, "4 chicken legs"));
        bookChallenges.Add(new Challenge(2, "That was so easy", "Complete any book", false, "5 chicken legs"));

        // Linked the list to the list of books that's in User
        source = GameObject.Find("ContInfo");
        challengeList = source.GetComponent<User>().getChallenges();
        FillList();
    }

    // Update is called once per frame
    public void FillList()
    {

        for (int i = 0; i < challengeList.Count; i++)
        {
            GameObject holder = Instantiate(itemHolderPrefab, grid, false);
            ChallengeItemHolder holderScript = holder.GetComponent<ChallengeItemHolder>();

            // Fills in information for the challenge items
            holderScript.challengeTitle.text = challengeList[i].GetTitle();
            holderScript.challengeDescription.text = challengeList[i].GetDescription();
            holderScript.complete = challengeList[i].GetStatus();
            if (holderScript.checkMark == null)
            {
                Debug.LogError("Some variable has not been assigned", this);
            }
            holderScript.rewardAmount.text = challengeList[i].GetReward().ToString();
            holderList.Add(holder);
         
        }
        updateColor();
        updateCheck();
    }
    public void updateColor()
    {
        for (int i = 0; i < holderList.Count; i++)
        {
            ChallengeItemHolder holderScript = holderList[i].GetComponent<ChallengeItemHolder>();
            if (holderScript.complete == true)
            {
                holderScript.challengeFrame.GetComponent<Image>().color = new Color32(35, 243, 0, 255);
            }
            else if (holderScript.complete == false)
            {
                holderScript.challengeFrame.GetComponent<Image>().color = new Color32(196, 0, 243, 255);
            }
        }
    }
    public void updateCheck()
    {
        for (int i =0; i < holderList.Count; i++)
        {
            ChallengeItemHolder holderScript = holderList[i].GetComponent<ChallengeItemHolder>();
            if(holderScript.complete == true)
            {
                holderScript.checkMark.SetActive(true);
            }
            else
            {
                holderScript.checkMark.SetActive(false);
            }
        }
    }
       
}
