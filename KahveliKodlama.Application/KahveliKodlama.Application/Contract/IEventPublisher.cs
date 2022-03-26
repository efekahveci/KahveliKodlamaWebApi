using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;
public partial interface IEventPublisher {
    void PublishAsync<TEvent>(TEvent @event);
}
