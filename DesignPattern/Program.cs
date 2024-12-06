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
using DesignPattern.P_Iterator;

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

#region Composite

//new ComponentTest().Run();

#endregion Composite

#region Memento

//new MementoTest().Run();

#endregion Memento

#region Iterator

new IteratorTest().Run();

#endregion Iterator

Console.ReadLine();