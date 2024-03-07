using rick_and_morty_maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rick_and_morty_maui.Services
{
    internal interface IRickAndMortyService
    {
        public Task<RickAndMorty> Get();
    }
}
