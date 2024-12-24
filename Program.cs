using System;
namespace StringExercise {
    public class StudentInput {
        public string[] NewArray() {
            string [] musician = {"John","Mike","Joe","Kevin"};
           return musician;
        }
    }
    class Program{
        static void Main (string [] args){
            StudentInput music = new StudentInput();
            string[] musicians = music.NewArray();
            Console.WriteLine(musicians[0]);
        }
    }
}
