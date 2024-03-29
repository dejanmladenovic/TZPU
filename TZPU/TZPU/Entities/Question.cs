﻿using System;
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

        public bool CheckCorect(String answer)
        {
            if (answer == _correctAnswer)
                return true;
            else
                return false;

        }
    }
}