// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку
string str = "English texts for beginners to practice reading and comprehension online and for free. "
            +"Practicing your comprehension of written English will both improve your vocabulary and "
            +"understanding of grammar and word order. The texts below are designed to help you develop "
            +"while giving you an instant evaluation of your progress.";
System.Console.WriteLine(str);
System.Console.WriteLine();
string s1 = "w";
string s2 = "v";
str = str.Replace(s1,s2);
System.Console.WriteLine(str);