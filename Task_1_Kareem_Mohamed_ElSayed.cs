

/* الاسم:كريم محمد السيد عبد الجواد */

using System;

namespace GradeCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
    double Assignments, MidTerm, FinalExam, ClassParticipation, FinalScore, Diff;
    Console.Write("Enter Assignments Score (0 - 100): ");
   Assignments = Convert.ToDouble(Console.ReadLine());
      if(Assignments>100 || Assignments<0) {
      
      Console.Write("\nEnter a Proper Assignments Score From 0 To 100: ");
      Assignments = Convert.ToDouble(Console.ReadLine());
      }
      
      
      Console.Write("\nEnter MidTerm Score (0 - 100): ");
   MidTerm = Convert.ToDouble(Console.ReadLine());
      if(MidTerm>100 || MidTerm<0) {
      
      Console.Write("\nEnter a Proper MidTerm Score From 0 To 100: ");
      MidTerm = Convert.ToDouble(Console.ReadLine());
      }
      
      
      Console.Write("\nEnter FinalExam Score (0 - 100): ");
   FinalExam = Convert.ToDouble(Console.ReadLine());
      if(FinalExam>100 || FinalExam<0) {
      
      Console.Write("\nEnter a Proper FinalExam Score From 0 To 100: ");
      FinalExam = Convert.ToDouble(Console.ReadLine());
      }
      
      
      Console.Write("\nEnter ClassParticipation Score (0 - 100): ");
   ClassParticipation = Convert.ToDouble(Console.ReadLine());
      if(ClassParticipation>100 || ClassParticipation<0) {
      
      Console.Write("\nEnter a Proper ClassParticipation Score From 0 To 100: ");
      ClassParticipation = Convert.ToDouble(Console.ReadLine());
      }
      
      FinalScore=(Assignments*30/100)+(MidTerm*25/100)+(FinalExam*35/100)+(ClassParticipation*10/100);
      Console.WriteLine("\nThe Final Score is {0}",FinalScore);
		
		if(FinalScore>90) {
                Console.WriteLine("\nYour Grade is A");

                if(FinalScore>=97) {
                    Console.WriteLine("\nYou are Outstanding");
                }

                else if(FinalScore>=93){
                    Console.WriteLine("\nYou are Excellent");
                }

                else {
                    Console.WriteLine("\nYou are Great");
                }
            }

        else if(FinalScore>80) {
                Console.WriteLine("\nYour Grade is B");
                
                if(FinalScore>=87) {
                    Console.WriteLine("\nYou are Very Good");
                }

                else if(FinalScore>=83){
                    Console.WriteLine("\nYou are Good");
                }

                else {
                    Console.WriteLine("\nYou are Satisfactory");
                }
                
            }


        else if(FinalScore>70) {
                Console.WriteLine("\nYour Grade is C");

                if(FinalScore>=77) {
                    Console.WriteLine("\nYou are Average +");
                }

                else if(FinalScore>=73){
                    Console.WriteLine("\nYou are Average");
                }

                else {
                    Console.WriteLine("\nYou are Below Average");
                }
            }

        else if(FinalScore>60) {
                Console.WriteLine("\nYour Grade is D");
            }

        else {
                Console.WriteLine("\nYour Grade is F");
            }
		
		if(Assignments<60 && FinalExam>=85) {
             Console.WriteLine("\nYou Failed at Assignments But You did Well in Final Exam");
             
         }
         
         
        if(Assignments>=90 && FinalExam<70) {
             Console.WriteLine("\nYou are Excellent at Assignments But You have to Work Harder Because Your Score in Final Exam is Below Average");
             
         }
		
		
        if (Assignments>MidTerm) {
             Diff=Assignments-MidTerm;
             Console.WriteLine("\nAssignments Score higher than MidTerm by {0}", Diff+ "\n"+"\nYou Improved By "+((Assignments/MidTerm)*100)+"%");
         }
             
             
        else if (Assignments<MidTerm) {
             Diff=MidTerm-Assignments;
             Console.WriteLine("\nMidTerm Score higher than Assignments by {0}", Diff+ "\n"+"\nYou Improved By "+((MidTerm/Assignments)*100)+"%");
         }
         
        else {
             Console.WriteLine("\nYou Got the same Score You did not Improve");
         }
         
    }
  }
}