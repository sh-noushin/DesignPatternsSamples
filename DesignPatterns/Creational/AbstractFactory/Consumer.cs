using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Consumer class that does not know whitch factory class will be sent to it.
    /// </summary>
    class Consumer
    {
        private readonly IGuiFactory factory;

        public Consumer(IGuiFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            var button = factory.CreateButton();
            var checkbox = factory.CreateCheckbox();

            button.Render();
            checkbox.Render();
        }
    }
}
