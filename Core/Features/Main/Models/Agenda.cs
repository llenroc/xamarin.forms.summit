﻿using Realms;
using System.Collections.Generic;

namespace Xamarin.Summit
{
    public class Agenda : RealmObject, IAgenda
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public IList<TimeLine> TimeLine { get; }
    }
}
