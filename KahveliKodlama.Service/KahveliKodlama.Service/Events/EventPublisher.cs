using KahveliKodlama.Application.Contract;
using KahveliKodlama.Infrastructure.ContextEngine;
using Serilog;
using Serilog.Context;
using System;
using System.Linq;
using System.Text.Json;

namespace KahveliKodlama.Service.Events;

public partial class EventPublisher : IEventPublisher
{

    public virtual void PublishAsync<TEvent>(TEvent @event)
    {
        //get all event consumers
        var consumers = EngineContext.Current.ResolveAll<IConsumer<TEvent>>().ToList();

        foreach (var consumer in consumers)
        {
            try
            {

                Log.Warning($"_event publish :  {JsonSerializer.Serialize(@event)}");

                //try to handle published event
                consumer.HandleEventAsync(@event);

            }
            catch (Exception exception)
            {

                try
                {
                    LogContext.PushProperty("ex", exception.Message);


                }
                catch
                {

                }
            }
        }
    }

}
