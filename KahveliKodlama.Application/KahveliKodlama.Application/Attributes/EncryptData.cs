using System;

namespace KahveliKodlama.Application.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class EncryptData : System.Attribute
    {
        public EncryptData()
        {
        }
    }
}
