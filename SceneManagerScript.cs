using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Timers;


public class SceneManagerScript : MonoBehaviour  {

    public Text ValueTxt;
    public Text ValueTokenID0000001Element;
    private static Timer timer;
    public float timeRemaining = 77;
    public float timeRemaining2 = 77;
    public float timeRemaining3 = 2819;
    public float timeRemaining4 = 2819;
    public bool timeset,timeset2;
    public bool timeset3, timeset4;
    public char _holdTokenID0000001Element;
    public char _holdTokenID0000001ElementBroadcast;
    public char SceneFour_holdTokenID0000001ElementBroadcast;
    private void Start()

    
    {
        
        ValueTxt.text = PersistentManagerScript.Instance.Value.ToString();
        //display the broadcast of the nft tokenID
        ValueTokenID0000001Element.text = PersistentManagerScript.Instance.holdTokenID0000001Element.ToString();
        //MyFunction(20, "Sergio");



    }
    class TestMetaverseConnect : MetaverseConnect
    {

        public override double GetTopSpeed()
        {
            return 108.4;
        }

        static void Main()
            
        {

            TestMetaverseConnect moto = new TestMetaverseConnect();
            
           
            moto.StartEngine();
            moto.AddGas(15);
            moto.Drive(5, 20);
            double speed = moto.GetTopSpeed();
           //Debug.Log("My top speed is {0}", speed);
        }
    }
    void Update()
    {
        //get the characters of the nft tokenID string held in the array
        //always starting at zero after scene is selected
        //this could be subroutine count of the array
        //or it gets called as a function
        //press button to trigger to set time remaining/loop count
        //once loop finishes at both counters at 0 }

        MyFunction(PersistentManagerScript.Instance.holdTokenID0000001Element);
        //We can now call the TestMetaVerseConnect class and create a Metaverse Connection OBJECT
        //for broadcasting the Token ID and testing it against JSON or network packet  
         

        //the char chamges as the myfuction is called with update method once triggered
        //game loop in a function
        _holdTokenID0000001ElementBroadcast = PersistentManagerScript.Instance.holdTokenID0000001Element;

    }


    void MyFunction(char aNumbe)
    {
        //Debug.log("Hello : " + aName + " you are " + aNumber + " years old.");
        if (timeRemaining > 0 && timeRemaining2==77)
        {
            timeRemaining -= Time.deltaTime;
            //PersistentManagerScript.Instance.holdTokenID0000001Element++;
            _holdTokenID0000001Element = PersistentManagerScript.Instance.holdTokenID0000001Element++;
            
        }
  
    
        if (timeRemaining == 0 && timeRemaining2 >0)
        {
            timeRemaining2 -= Time.deltaTime;
            //PersistentManagerScript.Instance.holdTokenID0000001Element++;
            _holdTokenID0000001Element = PersistentManagerScript.Instance.holdTokenID0000001Element--;
            
        }

        if (timeRemaining == 0 && timeRemaining2 == 0)
        {
            //reset timer
            timeRemaining = 77;
            timeRemaining2 = 77;
        }
         
            return;
    }

        public void GotoFirstScene()
    {

        SceneManager.LoadScene("character");
        PersistentManagerScript.Instance.Value++;
        _holdTokenID0000001ElementBroadcast = PersistentManagerScript.Instance.holdTokenID0000001Element;
        //PersistentManagerScript.Instance.Value++;



    }

    public void GotoSecondScene()
    {

        SceneManager.LoadScene("geoTag");
        PersistentManagerScript.Instance.Value++;
       



    }


    public void GotoThirdScene()
    {

        SceneManager.LoadScene("LAR");
        PersistentManagerScript.Instance.Value++;
    }

    public void GotoFourthScene()
    {

        SceneManager.LoadScene("Level1");
        PersistentManagerScript.Instance.Value++;

        SceneFour_holdTokenID0000001ElementBroadcast = _holdTokenID0000001ElementBroadcast;
    }

    public void GotoFifthScene()
    {

        SceneManager.LoadScene("Level2");
        PersistentManagerScript.Instance.Value++;
    }


    public void GotoSixthScene()
    {

        SceneManager.LoadScene("Level3");
        PersistentManagerScript.Instance.Value++;
    }

    public void GotoSeventhScene()
    {

        SceneManager.LoadScene("Level4");
        PersistentManagerScript.Instance.Value++;
    }


    public void GotoEigthScene()
    {

        SceneManager.LoadScene("maps");
        PersistentManagerScript.Instance.Value++;
    }

    public void GotoNinthScene()
    {

        SceneManager.LoadScene("Nano");
        PersistentManagerScript.Instance.Value++;
    }
    public void GotoTenthScene()
    {

        SceneManager.LoadScene("Level5");
        PersistentManagerScript.Instance.Value++;
    }

    public void GotoThirdpersonScene()
    {

        SceneManager.LoadScene("thirdperson");
        PersistentManagerScript.Instance.Value++;
    }


    public void GotoEleventhScene()
    {

        SceneManager.LoadScene("start");
        PersistentManagerScript.Instance.Value++;
    }
  
}
abstract class MetaverseConnect
{
    // Anyone can call this.
    public void StartEngine() {/* Method statements here */ }

    // Only derived classes can call this.
    protected void AddGas(int gallons) { /* Method statements here */ }

    // Derived classes can override the base class implementation.
    public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

    // Derived classes must implement this.
    public abstract double GetTopSpeed();
}

