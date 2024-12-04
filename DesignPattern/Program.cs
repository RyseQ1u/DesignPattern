// See https://aka.ms/new-console-template for more information
using DesignPattern.C_Decorator;
using DesignPattern.I_Builder;
using DesignPattern.J_Observer;
using DesignPattern.K_AbsFactory;
using DesignPattern.L_State;
using DesignPattern.M_Adapter;
using DesignPattern.M_Adapter.Adapters;
using DesignPattern.N_Composite;
using DesignPattern.N_Composite.Compoents;
using DesignPattern.O_Memento;

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

//new StateTest().Run();

#endregion State

#region Adapter

//new AdapterTest().Run();

#endregion Adapter

#region Component

//new ComponentTest().Run();

#endregion Component

#region Memento

new MementoTest().Run();

#endregion Memento

Console.ReadLine();