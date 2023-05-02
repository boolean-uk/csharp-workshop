using csharp_workshop.overloading;
using System.Text;
/*
AddingUpHelper addingUpHelper = new AddingUpHelper();

int integerResult = addingUpHelper.AddIntegers(23, 2);
Console.WriteLine(integerResult);


double doubleResult = addingUpHelper.AddDouble(20.3, 20.1);
Console.WriteLine(doubleResult);
*/



AddingUpHelperClass adderClass = new AddingUpHelperClass();


int integerResult = adderClass.AddTwoIntegers(1, 2);
Console.WriteLine(integerResult);

double doubleResult = adderClass.AddTwoDoubles(20.3, 20.1);
Console.WriteLine(doubleResult);



int overloadedIntResult = adderClass.Add(1, 2);
double overloadedDoubleResult = adderClass.Add(1.0, 3.1);


double d = adderClass.Add(1.0, 3);


StringBuilder s = new StringBuilder();
s.Append("hello");





