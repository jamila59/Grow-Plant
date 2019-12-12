using System;
using System.Collections.Generic;
using Grow.Plant;

namespace Grow.Plant
{
    class Plant // private field
    { 
        private int _waterlevel;
        private string _happiness;
        private int _glucoselevel;
        

        public Plant(int waterlevel, string happiness, int glucoselevel) // constructor 
        {
            _waterlevel = waterlevel;
            _happiness = happiness;
            _glucoselevel = glucoselevel;
        }
        
        public int IncreaseWater()
        {
            _waterlevel++;
            return _waterlevel;
        }
        public int IncreaseGlucose()
        {
             return _glucoselevel++;
        }

        public string Mood()
        {
            if (_glucoselevel > 2)
            {
                return "Happy";
            }
            else if (_waterlevel < 3)
            {
                return "Please, iam so very thirsty...";
            }
            else 
            {
                return "Yo";
            }
        }
    }
}