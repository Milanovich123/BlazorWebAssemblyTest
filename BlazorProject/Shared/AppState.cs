using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorProject.Shared.ResponseClasses;

namespace BlazorProject.Shared
{
    public class AppState
    {
        public string Message { get; private set; } = "";
        public bool Enabled { get; private set; } = false;
        public int Counter { get; private set; } = 0;
        public UserResponse user { get; set; }

        private bool _loggedIn;
        public event Action OnChange;
        public bool LoggedIn
        {
            get { return _loggedIn; }
            set
            {
                if (_loggedIn != value)
                {
                    _loggedIn = value;
                    NotifyStateChanged();
                }
            }
        }

        public void UpdateMessage(string Message)
        {
            this.Message = Message;
            Console.WriteLine(Message);
            NotifyStateChanged();
        }
        public void UpdateEnabled(bool Enabled)
        {
            this.Enabled = Enabled;
            NotifyStateChanged();
        }
        public void UpdateCounter(int Counter)
        {
            this.Counter = Counter;
            NotifyStateChanged();
        }
        public void UpdateUser(UserResponse user)
        {
            this.user = user;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
