using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;
public interface IConsumer<T> {
    void HandleEventAsync(T eventMessage);
}
