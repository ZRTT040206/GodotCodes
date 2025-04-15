using Godot;
using System;

public partial class ionputs : Node
{
    //? 针对输入用什么的问题，处理高频输入和单次触发用Input，处理复杂输入逻辑或者及时响应用@event，需要注意@event中尽量不写逻辑

    //todo 1.Input函数
     //通过godot设置中的输入映射，将某个输入设为字符串，例如 "up"设为'w'
     //可通过Input.某些函数直接调用
     /*
     *键盘
        ! Input.IsActionPressed("up"); 检测up对应的按键是否处于持续按下状态 适合再_Process中持续检测（移动）

        ! Input.IsActionJustPressed("up"); 检测动作是否再当前帧刚刚按下，一次按下只生效一次

        ! Input.IsActionJustRelesased("up"); 检测按键是否在当前帧被释放，

        ! Input.IsKeyPressed(keycode) 检测某个按键是否被按下
    *鼠标
        ! Input.IsMouseButtonPressed(buttom) 检测鼠标按键是否被按下
            ?比如 MouseButtom.Left/Right
        ! Input.GetMousePosition() 检测鼠标位置，返回Vector2

        ! Input.SetMouseMode(Input.MouseMode Mode) 设定鼠标模式，比如隐藏，锁定到窗口等


     */

    //todo 2.碰撞检测
     /* 
        两个都包含Area2D节点(并且添加CollisionShape2D)的区域重叠都会产生信号 两个信号分别是 
       
        ! area_enter(area:Area2D) 进入被碰撞对象区域时触发
        ! area_exited(area:Area2D) 离开被碰撞区域时触发

        在对应节点内部创建函数，连接对应信号，加入 Area2D 参数，此时这个节点与其他节点(同样包含Area节点)碰撞时会发出以上两个信号
            ? 接收的 area:Area2D函数是被碰撞节点的Area节点的实例，可以用GetPartent<父节点类型>获取被碰撞节点的父节点  
    */ 
     public void peng(Area2D areas)
    {
        GD.Print(111);
        Sprite2D sb = areas.GetParent<Sprite2D>();
        sb.Position = new Vector2(100,100);
        //area节点可通过.Call()内部函数调用 
        // ?估计是因为属于动态调用，并没有完整的被碰撞函数的实例，故需要用.Call()进行调用
    }

}
