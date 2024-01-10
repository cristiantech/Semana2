using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1
{
    public class Date
    {
        #region Atributos Privados
        private int _day;
        private int _month;
        private int _year;
        #endregion
        #region  Constructores
        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }
        public Date(int day, int month, int year)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day);
        }
        #endregion
        #region  Propiedades
        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }
        public int Month
        {
            get => _month;
            set => _month = ValidateMonth(value);
        }
        public int Year
        {
            get => _year;
            set => _year = ValidateYear(value);
        }
        #endregion
        #region Metodos Publicos
        public void Print()
        {
            Console.WriteLine($"{Year}/{Month}/{Day}");
        }

        #endregion
        #region  Metodos Privados
        private int ValidateDay(int day)
        {
            if (day == 29 && _month == 2 && IsLeapYear(_year))
            {
                return day;
            }
            throw new ArgumentException("This day is not valid ");
        }
        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private int ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("This month is not valid");
            }
            return month;
        }

        private int ValidateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("This year is not valid");
            }
            return year;
        }
        #endregion
    }
}
