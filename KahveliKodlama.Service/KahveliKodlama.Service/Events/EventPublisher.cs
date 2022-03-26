using KahveliKodlama.Application.Contract;
using KahveliKodlama.Infrastructure.ContextEngine;
using Serilog;
using Serilog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Events;

public partial class EventPublisher:IEventPublisher {

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
                //log error, we put in to nested try-catch to prevent possible cyclic (if some error occurs)
                try
                {
                    LogContext.PushProperty("ex", exception.Message);


                   // Console.WriteLine(exception.Message);
                    //Loglama
                   // await logger.ErrorAsync(exception.Message, exception);
                }
                catch
                {
                    // ignored
                }
            }
        }
    }

}
