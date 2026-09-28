using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Domain.Entities
{
    public class Platform
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Platform(string name)
        {
            ValidateName(name);
            Name = name;
        }   

        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("O nome da Plataforma não pode ser nulo ou vazio.");
            }
        }
    }
}