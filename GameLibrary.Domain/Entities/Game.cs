using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GameLibrary.Domain.Entities
{
    public class Game
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string? Description { get;  private set; }
        public GameType Type { get; private set; }
        public DateOnly? ReleaseDate { get; private set; }
        public int PlatformId { get; private set; }

        public Game(string name, int platformId, GameType type)
        {
            ValidateNameGame(name);
            ValidatePlatformId(platformId);
            Name = name;
            PlatformId = platformId;
            Type = type;
        }
        private void ValidateNameGame(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("O nome do Jogo não pode ser nulo ou vazio.");
            }
        }
        private void ValidatePlatformId(int platformId)
        {
            if (platformId <= 0)
            {
                throw new ArgumentException("O ID da Plataforma não pode ser nulo ou inválido.");
            }
        }
    }
}