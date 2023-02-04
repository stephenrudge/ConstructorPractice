// constructorPractice


using ConstructorPractice;

Person stephen = new Person();


stephen.name = "Stephen";
stephen.Age = 31;
stephen.HairColor = "black";
Console.WriteLine($"{stephen.name} is my name. I am {stephen.Age} years old and have {stephen.HairColor} hair. ");


Person Jeremy= new Person("Jeremy", "Brown", 30);
Console.WriteLine($"{Jeremy.name} is my name. I am {Jeremy.Age} years old and have {Jeremy.HairColor} hair. ");


