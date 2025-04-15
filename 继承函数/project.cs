using Godot;
using System;

public partial class project : Node{
    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);//delta为上一帧到当前帧的时间
        //固定时长调用，物理帧，固定60帧，每秒调用60次
    }
    public override void _Process(double delta)
    {
        base._Process(delta);//delta为上一帧到当前帧的时间
        //固定时长调用，非物理帧
        //可以用变量多次增加记录一秒
        //例如 nums += delta;
    }
    public override void _Ready()
    {
        base._Ready();//初始化函数，加入节点树时触发一次
        //后续如果未被销毁则不会重复触发
        //即未被销毁重复加入不会重新触发此函数
    }
    public override void _EnterTree()
    {
        base._EnterTree();//可作为初始化函数，加入节点树时触发
        //和_Ready的区别在于离开节点树后再次加入节点树会不会触发
        //即未被销毁再次加入场景树会再次触发
    }
    public override void _ExitTree()
    {
        base._ExitTree();
        //离开场景树触发，与_EnterTree 相同
        //一般与QueueFree()(递归删除节点函数)配合使用
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);//处理输入事件的函数
        //@event可以转为键盘输入、鼠标输入或者手柄输入等
        //可用Vector2I接收鼠标位置
        //! @event as InputEventKey 键盘事件名称  as为转化
        //! @event as InputEventMouseButton 鼠标事件名称  
        //! @event as IsInputEventJoypadButton 手柄事件名称
        /*
            鼠标事件名称.Left\Right\Middle\WheelUp\WheelDowm
            鼠标事件名称.Position(); 返回鼠标位置，返回值为Vector2I
            if (@event is InputEventMouseButton mouseEvent && 
            mouseEvent.ButtonIndex == MouseButton.Left &&!mouseEvent.Pressed)
            {                           可以判断鼠标放开时的信号，没有取反符号是判断鼠标按下的信号
                GD.Print("左键释放");
            }
          
        */
        //如果只是判断键盘可以用Input函数
    }

}
