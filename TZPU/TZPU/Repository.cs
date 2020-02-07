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
        

        protected Repository()
        {
           
            _questions = new List<Question>();

            ///////////////sejcuha 1 ////////////////////////////
            List<Data> odgovori = new List<Data>();
            odgovori.Add(new Image("birds1.jpg"));
            odgovori.Add(new Image("birds2.jpg"));
            odgovori.Add(new Image("birds3.jpg"));
            Question p1 = new Question("Pronaći sliku koja sadrži isti broj ptica kao na slici.", "3", odgovori, new Image("birdsintree.jpg"), 1);

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