﻿using System;
using System.Xml.Schema;

namespace ClassLibraryHighscore
{
    public class Highscore
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Highscore(int score, string name)
        {
            Score = score;
            Name = name;

        }

        










    }
}
