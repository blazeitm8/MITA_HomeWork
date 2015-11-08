using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;

        private string _currentcolor;

        public CatColor Color { get; set; }

        public int Health = 5;

        public Cat(CatColor color, string age)
        {
            Color = color;
            Age = age;
        }

        public string CurrentColor
        {
            get
            {
                 return Health < 5 ? Color.SickColor : Color.HealthyColor;
            }
        } 

        public string Name 
        { 
            get 
            {
                return _name;
            } 
            set 
            {
                if(string.IsNullOrEmpty(_name))
                {
                    _name=value;
                }
                else
                {
                    Console.WriteLine("Вы уже задали имя, повторно нельзя!");
                }
            }    
        }

        public string Age { get; }
        

        public void Feed()
        {
            Health++;
        }

        public void Punish()
        {
            Health--;
        }
    }
}
