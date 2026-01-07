// search task for week 1 
(Standard numeric format)

int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");
1- why the output of this Equation = $30.00? 
الناتج كان 30 دولار عشان ال C دا اسمه Format Specifier بيعبر عن العملة اللى هي دولار ف معنى الكود اني بقول لل compiler اجمع قيمة x , y واعرض dolar sign جنب ناتج جمعهم و حط بعد الناتج 2  decimal places
ف بالتالي الناتج بقى 30.00 $ 
2-what is its benefit? 
ال Standard numeric format specifiers بتسهل علينا واحنا بنكتب الكود عرض الارقام بطريقة سهلة زي المثال السابق استخدمنا C عشان تعبر عن ان الناتج هو 30 دولار ممكن نستخدم E دي مثلا بتخليني احط الرقم بتاعي فى صيغة exponential او ممكن نستخدم ال P 
دي بتخلي الرقم يتم التعبير عنه اكنه نسبة مئوية 
3-try another example with a different specifier 
double tax = 0.06;
Console.WriteLine($"Tax : {tax:P}"); 
الناتج اللى هيتعرض Tax : 6.00 % 
