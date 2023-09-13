{Console.WriteLine("The Temperature Adviser:")}
{Console.WriteLine("What is the current temperature in Celsius?")}

int temp = 15;
if (temp < 10) 
{Console.WriteLine("It is recommended that you wear warm clothing!");}
 
else if (temp >=10 and temp <=25)
{Console.WriteLine("It is recommended that you carry a light jacket.");}

else
{Console.WriteLine("Enjoy the weather!")}





{Console.WriteLine("Exam Grader:"):}

int grade = 90;

if (grade > 89) 
{Console.WriteLine("A grade received!");} 

else if (grade < 80) 
{Console.WriteLine("Below B grade received.");} 

else 
{Console.WriteLine("Grade received!");}



{Console.WriteLine("What's your favorite subject?:"):}

string favsubject = Console.ReadLine();

switch (favsubject)
{

case "Math":
    Console.WriteLine("Keep up the great work mathlete!")

case "Art":
    Console.WriteLine("Keep being unique, you got this!")

case "History":
    Console.WriteLine("Keep up the great work soldier!")

case "English":
    Console.WriteLine("You got this Shakespeare!")

}
