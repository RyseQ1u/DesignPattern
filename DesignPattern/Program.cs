// See https://aka.ms/new-console-template for more information
using DesignPattern.C_Decorator;
using DesignPattern.I_Builder;
using DesignPattern.J_Observer;
using DesignPattern.K_AbsFactory;

Console.WriteLine("Hello, World!");

#region Decorator

//Decorator.Test();

#endregion Decorator

#region Factory

//Decorator.Test();

#endregion Factory

#region Builder

//new BuilderTest().Run();

#endregion Builder

#region Observer

//new ObserverTest().Run();

#endregion Observer

#region AbsFactory

new AbsFactoryTest().Run();

#endregion AbsFactory

Console.ReadLine();