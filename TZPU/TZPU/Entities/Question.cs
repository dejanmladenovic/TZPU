using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TZPU.Entities
{
    public class Question
    {
        public String _textQuestion;
        public String _correctAnswer;
        public List<Data> _answers;
        public Data _partOFTheQuestion;
        public int _stage;
        public bool _answerUser;

        public Question(String textQuestion, String correctAnswer, List<Data> answers, Data partOFTheQuestion, int stage)
        {
            _textQuestion = textQuestion;
            _correctAnswer = correctAnswer;
            _answers = answers;
            _partOFTheQuestion = partOFTheQuestion;
            _stage = stage;
        }

        public String PrintQuestion()
        {
            String odgovor = "";

            return odgovor;
        }

        public void  CheckCorect(String answer)
        {
            if(answer == _correctAnswer)
            {
                _answerUser = true;
                if(_stage == 2)
                {
                    Repository.Instance._correctAnswersSecondSection++;
                }
                else if(_stage == 6)
                {
                    Repository.Instance._correctAnswersSixthSection++;
                }
            }
            else
            {
                _answerUser = false;
            }
        }
    }
}