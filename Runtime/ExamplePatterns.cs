//using CommandPattern;
//using System.Collections.Generic;
//using UnityEngine;

//public class ExamplePatterns : MonoBehaviour
//{
//    public static List<ObjectTest> Test = new List<ObjectTest>();
//    CommandList list = new CommandList();
//    void Start()
//    {
//        Test.Add(new ObjectTest() { Id = "2" });
//        Test.Add(new ObjectTest() { Id = "1" });
//        Print();
//        list.Push((new CreateObjectTest(new ObjectTest() { Id = "3" }).Do()));
//        Print();
//        list.Pop().Undo();
//        Print();
//    }
//    public void Print()
//    {
//        Debug.Log("-----------------------------");
//        foreach (ObjectTest t in Test)
//        {
//            Debug.Log(t.Id);
//        }
//    }
//}
//public class CreateObjectTest : Command
//{
//    public CreateObjectTest(ObjectTest data) : base(data){}

//    protected override void CommandDo()
//    {
//        ExamplePatterns.Test.Add(GetData<ObjectTest>());
//    }
    
//    protected override void CommandUndo()
//    {
//        ExamplePatterns.Test.Remove(GetData<ObjectTest>());
//    }
//}
//public class ObjectTest
//{
//    public string Id;
//}