using Godot;
using System;

public partial class signal : Node
{
    //todo 1. Call函数,Callable函数
    //! 节点名称.Call(“触发的函数名称（string）"，传递参数); 可以不用传递参数
    // Call函数适合动态调用方法，通过字符串查找需要调用的函数
    // 还有一个CallGroup函数可以给调用某一组节点内的方法
    //! Callable 呼叫名称 = new Callable(节点名称，"函数名称");
    //通过 呼叫名称.Call()便可以调用节点的内容
    //Callable是一个函数，用于节点之间的通信，开销小于Call，泛用性低于Call


    //todo 2. 设定信号
    //*设置信号
    //! [Signal]
    //! public delegate void 信号名称EventHandler(发送的参数);
    //*连接信号
    //! 节点名称.Connect(SignalName.信号名称，new Callable(节点名称，"节点内函数名称"));
    //*发送信号
    //! EmitSignal(SignalName.信号名称);
}
