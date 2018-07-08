using System;
using System.Collections.Generic;
using System.Linq;

namespace sessao1questao4
{
    public class ToroDictionary
    {
        /* Como há a necessidade de ordenar e remover itens em posições específicas na lista,
         * decidi usar List com locking ao invés das coleções thread safe de System.Collections.Concurrent.
         * Pode não ser a melhor opção em performance, depende da situação */
        private static List<KeyValuePair<int, string>> _dic = new List<KeyValuePair<int, string>>();
        private static Object _listLock = new Object();

        public void Add(int id, string text)
        {
            lock (_listLock)
            {
                _dic.Add(new KeyValuePair<int, string>(id, text));
            }
        }

        public void Remove(int id)
        {
            lock(_listLock)
            {
                _dic.Remove(_dic.Where(x => x.Key == id).FirstOrDefault());
            }

        }

        public List<KeyValuePair<int, string>> SortByKey()
        {
            lock (_listLock)
            {
                return _dic.OrderBy(x => x.Key).ToList();
            }
        }
    }
}
