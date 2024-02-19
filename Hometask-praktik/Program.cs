
//Hometask

//1)Parametr olaraq string qebul eden metod yazmalisiz. 
//Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. 
//(Cavid gelirse , ekranda divaC gorsensin).


//string MyMethods(string text)
//{
//    string result = string.Empty;
//    for (int i = text.Length - 1; i >= 0; i--)
//    {
//        result += text[i];
//    }
//    return result;
//}
//Console.WriteLine(MyMethods("Cavid"));









//PRAKTIK



//int[] arr = { 1, 23, 4, 5 };

//foreach(var item in arr)
//{
//    Console.WriteLine(item);
//}



//int[] arr = { 1, 23, 4, 5 };
//arr[1] = 100;

//List<int> datas = new() { 1,2,3,4};

//datas.Add(100);

//string name = "Test";

//string newName = name + "salam";






//string name = "test";

//name = "salam";


//using System.Text;

//StringBuilder str = new StringBuilder("salam");

//str.Append("sagol");




//int age = 100;

//Console.WriteLine(age.ToString().GetType());


//string surname = "Hello,World";

//Console.WriteLine(surname.Length);


//string str1 = "salam";
//string str2 = " necesiz ?";

//string result=string.Concat(str1, str2);

//Console.WriteLine(result);



//string result = "";

//string result2 = string.Empty;

//var result3 = result + "salam";

//Console.WriteLine(result3);


//string text = string.Empty;

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("full");
//}



//string text = "salam";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("full");
//}




//string text = "   ";

//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("full");
//}



//string text = "Azerbaycan";

//Console.WriteLine(text.ToUpper());

//Console.WriteLine(text.ToLower()); 


//string str1 = "Apple";
//string str2 = "apple";

//Console.WriteLine(str1.ToLower()==str2.ToLower());



//string str1 = "  Apple";
//string str2 = "apple   ";

//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());



//string str1 = "  Apple";
//string str2 = "apple   ";


//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));



//string str1 = "  Apple";
//string str2 = "apple   ";

//Console.WriteLine(CheckStr(str1).Equals(CheckStr(str2)));


//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}


//string str1 = "  Apple";
//string str2 = "apple   ";

//string str = "Salam";
//Console.WriteLine(str);


//string text = "Azerbaycan";

//Console.WriteLine(string.Format(text));



//string peoples = "salam,dunya";

//Console.WriteLine(peoples);

//string[] peoplesList =peoples.Split(',');

//foreach (var item in peoplesList)
//{
//    Console.WriteLine(item);
//}


//string text = "Salam Azerbaycan";

//Console.WriteLine(text.Replace("Salam","Sagol"));



//string text = "Salam Azerbaycan";

//string result = text.Substring(0, 5) + "...";

//Console.WriteLine(result);


//string text = "Salam Azerbaycan";

//Console.WriteLine(text.Contains("Salam"));




//bool CheckCharInStr(string text,char letter)
//{
//    return text.Trim().Contains(letter);
//}

//Console.WriteLine(CheckCharInStr("Baku", 'a'));



//bool CheckCharInStr(string text, string letter)
//{
//    return text.Trim().ToLower().Contains(letter.Trim().ToLower());
//}

//Console.WriteLine(CheckCharInStr("Baku", "a"));


//bool CheckCharInStr(string text, string letter)
//{
//    return text.Trim().ToLower().Contains(letter.Trim().ToLower());
//}

//Console.WriteLine("Add text;");
//string text=Console.ReadLine();

//Console.WriteLine("Add search text");
//string searchText=Console.ReadLine();

//if (CheckCharInStr(text, searchText))
//{
//    Console.WriteLine("Found");
//}
//else
//{
//    Console.WriteLine("Not Found");
//}


