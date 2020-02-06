using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TZPU.Entities;

namespace TZPU
{
    public class Repository
    {
        private static Repository instance;
        private static object locker = true;

        public static Repository Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new Repository();
                }
                return instance;
            }
        }

        public List<Question> _questions { get; set; }
        public int _currentQuestion { get; set; }
        public int _oldChild { get; set; }
        public int _correctAnswersSecondSection { get; set; }
        public int _correctAnswersSixthSection { get; set; }
     

        protected Repository()
        {
            _correctAnswersSecondSection = 0;
            _correctAnswersSixthSection = 0;
            _currentQuestion = -1;
            _questions = new List<Question>();

            ///////////////sejcuha 1 ////////////////////////////
            List<Data> odgovori = new List<Data>();
            odgovori.Add(new Text("10"));
            odgovori.Add(new Text("12"));
            odgovori.Add(new Text("15"));
            Question p1 = new Question("Pitanj 1", "1", odgovori, new Text("10"), 1);

            _questions.Add(p1);

            List<Data> odgovori1 = new List<Data>();
            odgovori1.Add(new Text("10"));
            odgovori1.Add(new Text("12"));
            odgovori1.Add(new Text("15"));
            Question p2 = new Question("Pitanj 2", "2", odgovori1, new Text("10"), 1);

            _questions.Add(p2);

        }
    }
}