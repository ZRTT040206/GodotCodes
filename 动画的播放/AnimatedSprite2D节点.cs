using Godot;
using System;

public partial class AnimatedSprite2D2 : AnimatedSprite2D
{
    public override void _PhysicsProcess(double delta)
    {

        //*在编辑器中进行动画的编辑，之后尽享如下操作
        //! 1. 基础操作
        this.Animation = "aaa"; //设置当前的的动作名称
        this.Play();//播放动画
        this.Stop();//停止动画
        this.IsPlaying();//判断动画是否正在进行

  base._PhysicsProcess(delta);
    } 
}