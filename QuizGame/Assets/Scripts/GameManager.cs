using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text textA;
    [SerializeField]
    private Text textB;
    [SerializeField]
    private Text textC;
    [SerializeField]
    private Text textD;


    [SerializeField]
    private float timeBetweenFacts = 2f;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    private void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;
        textA.text = currentQuestion.textA;
        textB.text = currentQuestion.textB;
        textC.text = currentQuestion.textC;
        textD.text = currentQuestion.textD;
    }

    IEnumerator TransitionToNextFact()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenFacts);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectA()
    {
        if (currentQuestion.isA)
        {
            answerA.gameObject.SetActive(true);
            //puan kazanabilir
        }
        else if (currentQuestion.isB)
        {
            answerB.gameObject.SetActive(true);
        }
        else if (currentQuestion.isC)
        {
            answerC.gameObject.SetActive(true);
        }
        else if (currentQuestion.isD)
        {
            answerD.gameObject.SetActive(true);
        }

        StartCoroutine(TransitionToNextFact());
    }
    public void UserSelectB()
    {
        if (currentQuestion.isA)
        {
            answerA.gameObject.SetActive(true);
        }
        else if (currentQuestion.isB)
        {
            answerB.gameObject.SetActive(true);
            //puan kazanabilir
        }
        else if (currentQuestion.isC)
        {
            answerC.gameObject.SetActive(true);
        }
        else if (currentQuestion.isD)
        {
            answerD.gameObject.SetActive(true);
        }

        StartCoroutine(TransitionToNextFact());
    }
    public void UserSelectC()
    {
        if (currentQuestion.isA)
        {
            answerA.gameObject.SetActive(true);
        }
        else if (currentQuestion.isB)
        {
            answerB.gameObject.SetActive(true);
        }
        else if (currentQuestion.isC)
        {
            answerC.gameObject.SetActive(true);
            //puan kazanabilir
        }
        else if (currentQuestion.isD)
        {
            answerD.gameObject.SetActive(true);
        }

        StartCoroutine(TransitionToNextFact());
    }
    public void UserSelectD()
    {
        if (currentQuestion.isA)
        {
            answerA.gameObject.SetActive(true);
        }
        else if (currentQuestion.isB)
        {
            answerB.gameObject.SetActive(true);
        }
        else if (currentQuestion.isC)
        {
            answerC.gameObject.SetActive(true);
        }
        else if (currentQuestion.isD)
        {
            answerD.gameObject.SetActive(true);
            //puan kazanabilir
        }

        StartCoroutine(TransitionToNextFact());
    }
}
