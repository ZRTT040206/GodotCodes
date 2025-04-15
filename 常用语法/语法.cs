using Godot;
using System;

public partial class 语法 : Node
{
    //! as 和 is
    //! 变量1 as 类型1 变量2  将变量1的类型转化为类型1，  
    //! 变量1 is 类型1        判断变量1是否为类型1(bool)
//*
    //! ref 和 out 
    /*
         ref                out
初始化   传递前初始化         方法内部初始化
赋值     可读取和修改变量     必须在方法内为参数赋值
用途     方法内修改变量       为方法返回多个值
    !    ref 类型 变量   out 类型 变量    用于在函数内部接收变量引用
    !    ref 变量        out 变量         用于调用函数时传递引用
    */
//*
    //todo 2.Vecotr2I
    //二维向量包含两个数，类似C++中的pair
    //! Vector2I 向量名称 = new Vector2I(x,y);//不加(x,y)默认不给向量赋初值 初值为0？
    //! 向量名称.X 向量名称.Y 可以调用x或y的值或者给xy赋值
    // 可以用Vector2I创建数组



    //todo foreach
    /*
    !   foreach (var item in collection) 通过item变量接收Collection的数据从而对collection进行遍历
    
    */
     
}
