// See https://aka.ms/new-console-template for more information
using DesignPattern.C_Decorator;
using DesignPattern.I_Builder;
using DesignPattern.J_Observer;
using DesignPattern.K_AbsFactory;
using DesignPattern.L_State;

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

//new AbsFactoryTest().Run();

#endregion AbsFactory

#region State

new StateTest().Run();

#endregion State

Console.ReadLine();