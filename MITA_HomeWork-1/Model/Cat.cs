using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        CatColor Color = new CatColor();

        public string CurrentColor; 
        private string _age;
        private string _name;
        public int Health = 5;

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

        public string Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (string.IsNullOrEmpty(_age))
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Вы уже задали возраст при покупке, повторно нельзя!");
                }
            }
        }
        
        public void Feed()
        {
            Health++;
            CurrentColor = Color.HealthyColor;
        }

        public void Punish()
        {
            Health--;
            CurrentColor = Color.SickColor;
        }
    }
}
