
System.Console.WriteLine("Welcome to New quiz app!!!");
string[][] quiz={
    
    new string[]{"1.Sonni raqamlarda yozing  23 mln 453 ming 6.","A) 23453006   B) 23405306  C) 2304536  D) 2345306","A"},
    new string[]{"2.Kesma bir uchi tomonga cheksiz davom ettirilsa qanday shakl hosil bo’ladi ?",
                    "A) Kesma   B) To’g’ri chiziq  C) Nur   D) Tekislik",
                        "B"},
    new string[]{"3.Sonlar nurida 23,12,19 va 35 sonlardan qaysi biri eng o’ngda joylashgan ?",
                    "A) 23  B) 35  C) 19   D)  12",
                        "3"},
    new string[]{"4.Santimetrda ifodalang . 6 dm  2 sm",
                    "A) 23  B) 35  C) 19   D)  12",
                        "B"},
    new string[]{"5. Mingda nechta o’n bor .",
                    "A) 4ta   B) 5ta   C) 3ta   D)2ta",
                        "B"},
    new string[]{"6.Tomonlari  12sm, 15sm,  17sm bo’lgan uchburchak peremetrini toping.",
                    "A) 46sm         B) 45 sm      C) 42 sm     D) 44 sm",
                        "C"},
    new string[]{"7. Son va harflar qatnashgan ifoda nima deyiladi.",
                    "A) Harfli ifoda  B) Sonli ifoda C) Yig’indi  D) Tenglama",
                        "C"},
    new string[]{"8. Ifodani qiymatini toping: 260+b-160 bunda b=93",
                    "A) 195        B) 8      C) 193      D) 7 ",
                        "C"},
    new string[]{"9. C nuqta AB kesmada yotadi. Agar  AB=24sm va CB=15sm ekanligi malum bo’lsa \nAC kesmaning uzunligini toping.",
                    " A) 9        B) 8      C) 11      D) 10",
                        "C"},
    new string[]{"10. Kit akuladan 20m uzunroq.  Agar kitning uzunligi 31m bo’lsa, akulaning uzunligini toping.",
                    " A) 9        B) 8      C) 11      D) 10",
                        "C"},
};
int correctAnswer=0;
int incorrectAnswer=0;
foreach(var item in quiz)
{
    Console.WriteLine(item[0]);
    Console.WriteLine(item[1]);
    bool answer=CheckAnswer(item[2].First());
    if (answer==true)
    {
        correctAnswer++;
    }
    else{
        incorrectAnswer++;
    }
}
System.Console.WriteLine("Your result:");
System.Console.WriteLine("Correct answer: {0}",correctAnswer);
System.Console.WriteLine("Incorrect answer: {0}",incorrectAnswer);

bool CheckAnswer(char answer)
{
    char input = Console.ReadKey().KeyChar;
    return char.ToUpper(input)==char.ToUpper(input);
}