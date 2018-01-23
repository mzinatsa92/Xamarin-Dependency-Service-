using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDepency
{
    public interface INotify
    {
        void UpdateNotification(string title, string text);
    }
}
