using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class NotificationCenter
    {
        private NotificationCenter() { }

        private static NotificationCenter _notificationCenter;
        
        public static NotificationCenter main
        {
            get
            {
                if(_notificationCenter==null)
                {
                    _notificationCenter = new NotificationCenter();
                }
                return _notificationCenter;
            }
        }

        Dictionary<string, List<Listener>> observers = new Dictionary<string, List<Listener>>();

        public void subscribe(string evento, Listener clase)
        {
           if(!observers.ContainsKey(evento))
            {
                observers.Add(evento, new List<Listener>());
            }
            observers[evento].Add(clase);
        }

        public void emit(string evento)
        {
            if (!observers.ContainsKey(evento))
            {
                observers.Add(evento, new List<Listener>());
            }
            for (int i=0; i<observers[evento].Count; i++ )
            {
                observers[evento].ElementAt(i).listen(evento);
            }
        }
    }
}
