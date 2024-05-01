using System;
using System.Threading.Tasks;

namespace LogoManager.Interface
{
    public interface ITCPService
    {
        public event EventHandler SendEventHandler;
        DateTime LastMessageTime { get; }
        Task Start(int port, string ipAddress);
        void Stop();
    }
}
