using Service.Domain;
using System.Collections.Generic;

namespace Musics
{
    public static class PlayList
    {
        /// <summary>
        /// Retorna a lista de músicas de um cliente
        /// </summary>
        /// <param name="cliente">Código do cliente</param>
        /// <returns></returns>
        public static List<Musica> ListMusicas(int cliente)
        {
            var service = new MusicaService();
            return service.GetClientMusicList(cliente);
        }
    }
}
