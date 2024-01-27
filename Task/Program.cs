
string[] strings = AddElements(5);



string[] AddElements(int size){
    string[] str = new string[size];
    for(int i=0; i<str.Length; i++){
        Console.WriteLine($"Enter the {i+1} string");
        str[i] = Console.ReadLine();
    }
    return str;
}