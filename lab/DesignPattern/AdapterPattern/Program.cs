using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlugIn plugin = new PlugIn();
            plugin.Charging(10, 5, 3);

            PlugInAdapter  adapter = new PlugInAdapter(new PlugIn());
            adapter.Charging(10, 5);
        }
    }
}
