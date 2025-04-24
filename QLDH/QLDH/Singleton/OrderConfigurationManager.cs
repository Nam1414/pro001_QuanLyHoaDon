using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH.Singleton
{
    public sealed class OrderConfigurationManager
    {
        private static readonly Lazy<OrderConfigurationManager> _instance =
            new Lazy<OrderConfigurationManager>(() => new OrderConfigurationManager());

        public static OrderConfigurationManager Instance => _instance.Value;

        public string Currency { get; set; } = "USD";

        private OrderConfigurationManager() { }
    }
}
