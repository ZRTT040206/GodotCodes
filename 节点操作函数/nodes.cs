using Godot;
using System;

public partial class nodes : Node
{
    //todo 1.添加节点
    //! 节点类型  节点名称   = new 节点名称(); 
    Node2D node = new Node2D();
    //或者也可以直接在图形化界面中添加节点
    //节点的常用操作可以看godot右侧检查器，包括节点位置移动等等

//*
public void add(){
    //todo 2. 添加子节点
    //! AddChild(节点类型);
    //! node.AddChild() 在某个节点添加子节点，node时节点树上的节点
    
        this.AddChild(node);
  
    //需要搭配获取节点的函数使用（后面写）

//*

    //todo 3.从场景实例化节点并实例化使用
    //! PackedScene 自定场景名  = GD.Load<PackedScene>("场景地址.tscn");
    PackedScene scene = GD.Load<PackedScene>("res://xx.tscn");
    //! 节点类型 节点名称 = 自定义的场景名.Instantiate<节点类型>()'
    Button button = scene.Instantiate<Button>();
    //此时此节点button可以当作子节点等添加到场景树中
    //即为 
//* 

    //todo 4.获取当前树上的节点
    //! 节点类型 节点名称 = GetNode<节点类型>("节点地址/节点名称");//获取某个节点
    Button nodess = GetNode<Button>("/root/main/button");//root是最大的根节点不加/root默认从/root开始
    nodess.AddChild(nodess);//* 添加场景先将场景实例化，再进行处理
    //! 节点类型 节点名称 = GetTree(); 获取整棵节点树（根节点）
    Button but =new Button();
    this.GetTree().CurrentScene.AddChild(but);//* 通过场景树添加子节点，也可以使用GetNode添加子节点
    //* CurrentScene用于将场景树转化为场景节点
    //GetTree()返回一个场景树，类型是SceneTree,

    //! 节点类型 节点名称 = GetTree().GetNodesInGroup("组名"); 获取树上的某个类型的节点，一般与foreach连用
    //通过节点便可以访问并更改这个节点上的所有元素
    //GetNodeOrNull()函数获取失败返回NULL

    //todo 检查节点和场景树的关系
    //! 节点类型 节点名称 = 树上的节点.GetPartent();获取树上的某个节点的父节点
    //! (bool) 树上的节点.IsInsideTree(); 判断某个节点是否在树上

//*

    //todo 直接将场景转化为节点
    //! GetTree().ChangeSceneToFile("res://xxx") 首先获取当前场景的根节点，然后转化为某个节点
}
}
