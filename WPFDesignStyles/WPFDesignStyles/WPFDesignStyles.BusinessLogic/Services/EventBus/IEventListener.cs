using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignStyles.BusinessLogic.Models.Events;

namespace WPFDesignStyles.BusinessLogic.Services.EventBus
{
    public interface IEventListener<T> where T : BaseEvent
    {
        void Receive(T @event);
    }
}
