Console.WriteLine("How is the whether");
string respons = Console.ReadLine();
if(respons == "Good" || respons == "good" ){
    Console.WriteLine("Let's go for a walk");
}
else if(respons == "bad" || respons == "Bad"){
    Console.WriteLine("let's stay inside and play mario cart");
}
else{
    Console.WriteLine("I do not understand");
}