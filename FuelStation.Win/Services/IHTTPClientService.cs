using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Services
{
    internal interface IHTTPClientService
    {
        Task<T> GetObject<T>(string controller, string id);
        Task<List<T>> GetObjectsList<T>(string controller);
        Task PostObject<T>(string controller, T obj);
        Task PutObject<T>(string controller, T obj);
        Task DeleteObject<T>(string controller, string id);
    }
}
