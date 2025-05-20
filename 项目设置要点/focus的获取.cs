// todo 1.让按钮或者其他的控件（节点）获取屏幕焦点
//      Button But = GetNode<Button>("/root/Title_Game/VBoxContainer/NewGame");
// 		But.FocusMode = FocusModeEnum.All;
        //! 用到高光必须要加入
// 		But.GrabFocus();

// todo 2.让光标随着鼠标移动
//   button.Connect(
                    // ? 让鼠标的信号和按钮的聚焦联系起来
//                     signal: Button.SignalName.MouseEntered,   
                    // ? 让被鼠标进入区域的按钮发出信号 
//                     callable: Callable.From(() => button.GrabFocus())
                    // ? 让Button节点被聚焦
            //! 或者这样写：
            /*
    !          public override void _Ready()
    !         {
	!            foreach(Button but in GetChildren())		
    !            {
	!	    	    but.Connect(Button.SignalName.MouseEntered, Callable.From(() => but.GrabFocus()));
	!            }
    ?                              
	!         }
            */