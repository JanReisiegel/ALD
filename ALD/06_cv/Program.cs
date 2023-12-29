// See https://aka.ms/new-console-template for more information
using _06_cv.Models;

//RegularExpresions reg = new RegularExpresions(@"E:/+TUL/3_semestr/ALD/Code/ALD/06_cv/vstup.html");//desktop
MyRegularExpresions reg = new MyRegularExpresions("C:/Users/jan/source/repos/ALD/ALD/06_cv/vstup.html");//laptop
//MyRegularExpresions reg = new MyRegularExpresions(); //solution
Console.WriteLine(reg.Print());