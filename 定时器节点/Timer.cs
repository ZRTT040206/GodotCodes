using Godot;
using System;

public partial class Timer :Node
{
    public override void _Ready()
    {
        /*
        todo 1.设定定时器
            ! 即为将定时器节点添加到节点树上
            ! Timer 定时器名称  = new Timer()
            
        todo 2.开关定时器
            ! 定时器.Start();
            !开启定时器

        todo 3.设定定时器定时时间
            ! 定时器名称.WaitTime  = (float)定时时间长短


        todo 4.判断定时器是否在运行中
            ! (bool) 定时器名称.IsStopped() 

        todo 5.获取定时器剩余时间
            ! float 剩余时间 = 定时器名称.TimeLeft；

        todo 6.定时器计数完成后触发
            ! Timeout信号
        */
    }

}