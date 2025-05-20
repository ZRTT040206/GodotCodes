using Godot;
using System;
using System.IO;//导入c#中的System.IO进行文件读取


public partial class Dialogs : CanvasLayer
{
    public override void _Ready()
    {
        /*
        *这是使用IO的
            todo 1.判断文件是否存在
                File.Exits("文件路径") 

            todo 2.读取文件
                using var files = Godot.FileAccess.Open(TextPaths,Godot.FileAccess.ModeFlags.Read);
		        必须适using在方法结束后的时候进行资源释放
		        string content = files.GetAsText();
                用content这个字符串读取文件，
                DiaCont = content.Split('\n');
                在DIaCont中存储字符串内容并且使用\n进行分割
        */
        base._Ready();
    }
}