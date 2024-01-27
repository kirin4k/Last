
string[] strings = AddElements(5);
string[] list = CheckElements(strings);
Print(list);

string[] AddElements(int size){
    string[] str = new string[size];
    for(int i=0; i<str.Length; i++){
        Console.WriteLine($"Enter the {i+1} string");
        str[i] = Console.ReadLine();
    }
    return str;
}


string[] CheckElements(string[] str){
    string[] list = new string[str.Length];
    int j=0;
    for(int i=0; i< str.GetLength(0); i++){
    if(str[i].Length<=3){
        list[j] = str[i];
        j++;
    }
    }
    return list;
}

void Print(string[] str){
    for(int i=0 ; i<str.Length; i++){
        Console.WriteLine(str[i]);
    }
}




















