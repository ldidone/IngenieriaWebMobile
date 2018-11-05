using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace WappoMobile.Contracts
{
    public interface INotificacionesService
    {
        Task<ObservableCollection<Notificacion>> ObtenerPedidos(string emailUsuario);
    }
}
