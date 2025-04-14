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
    

}
