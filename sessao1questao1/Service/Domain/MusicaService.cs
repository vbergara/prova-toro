using System;
using System.Collections.Generic;

namespace Service.Domain
{
    public class MusicaService
    {
        public List<Musica> GetClientMusicList(int clientId)
        {
            // MOCK do serviço
            var rnd = new Random();
            List<Musica> result = new List<Musica> {
                new Musica { codmusic = (clientId * rnd.Next(1, 20)).ToString() },
                new Musica { codmusic = (clientId * rnd.Next(1, 20)).ToString() },
                new Musica { codmusic = (clientId * rnd.Next(1, 20)).ToString() },
                new Musica { codmusic = (clientId * rnd.Next(1, 20)).ToString() },
                new Musica { codmusic = (clientId * rnd.Next(1, 20)).ToString() }
            };

            return result;
        }
    }
}
