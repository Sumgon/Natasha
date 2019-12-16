﻿using Natasha;
using System;

namespace Core20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *   在此之前，你需要右键，选择工程文件，在你的.csproj里面 
             *   
             *   写上这样一句浪漫的话： 
             *   
             *      <PreserveCompilationContext>true</PreserveCompilationContext>
             */


            string text = @"namespace HelloWorld
{
    public class Test
    {
        public Test(){
            Name=""111"";
        }

        public string Name;
        public int Age{get;set;}
    }
}";
            //根据脚本创建动态类
            AssemblyComplier oop = new AssemblyComplier("test");
            oop.Add(text);
            Type type = oop.GetType("Test");

            Console.WriteLine(type.Name);

            var action = NDomain.Random().Action("");
            var a = action.Method;
            Console.WriteLine(action.Method.Module.Assembly);


            Console.ReadKey();
        }
    }
}
