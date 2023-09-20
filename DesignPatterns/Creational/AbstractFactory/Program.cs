using AbstractFactory;

IGuiFactory windowsFactory = new WindowsGuiFactory();
IGuiFactory macosFactory = new MacOSGuiFactory();

Consumer windowsApp = new Consumer(windowsFactory);
Consumer macosApp = new Consumer(macosFactory);

Console.WriteLine("Creating UI for Windows:");
windowsApp.CreateUI();

Console.WriteLine("\nCreating UI for macOS:");
macosApp.CreateUI();