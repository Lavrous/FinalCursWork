using FinalCursWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalCursWork
{
    public class ClientInfo
    {
        private string _registrationNumber;
        private string _fullName;
        private string _phoneNumber;
        private string _address;
        public DateTime RegistrationTime { get; set; }
        public List<Requests.RequestBase> Requests { get; } = new List<Requests.RequestBase>();

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.All(char.IsDigit))
                    throw new ArgumentException("ФИО должно содержать только буквы.");
                _fullName = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Адрес не может быть пустым.");
                _address = value;
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\+7\d{10}$"))
                    throw new ArgumentException("Номер телефона должен соответствовать формату РФ.");
                _phoneNumber = value;
            }
        }

        public string RegistrationNumber
        {
            get => _registrationNumber;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 5 || !value.All(char.IsDigit))
                    throw new ArgumentException("Регистрационный номер должен быть числом из 5 цифр.");
                _registrationNumber = value;
            }
        }

        public const double Amount = 5000.0; // Всегда 5000 рублей
    }
}
