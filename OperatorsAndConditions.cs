/* start {  } end   */

// +
// -
// *
// /
// % - Qalığla bölünmə

// == əyər bərabərdirsə 
// >
// <
// >= böyük bərabərdirsə
// <= kiçik bərabərdirsə

// ++ Increment  
// -- Decrement

int x = 5;
x++;
Console.WriteLine(x); // x = 6
x--;
Console.WriteLine(x); // x = 5

if (true) /*biz burada bir boolean dəyəri alırıq və onun əsasında bu bloka daxil oluruq və ya olmuruğ*/
{

}else if (true) // bu bloka yuxarıdakı if blokuna daxil olmasaq bura daxil olacayığ
{

}
else // bu else bloku isə yuxarıdakılardan heç birinə daxil ola bilməsək
{

}
/* burada anındaca pare etməyə çalışırığ , ancaq istifadəçi
 rəqəm yerinə hərif daxil etsə exception alacayığ */
int number = int.Parse(Console.ReadLine()); 
Console.WriteLine(number);


/* burada isə inputu aldığdan sonra int ə çevirməyə cəhd edirik
   bu daxili funksiada baş verdiyindən biz geriyə true və ya false əldə edirik
   int.TryParse alınan rəqəmi number type çevirə bilsə checkNumber dəişənin içinə yazacaq
   əyər çevirə bilməsə else blokuna daxil olacayıq , bu o deməkdirki istifadəçi rəqəm yerinə
   hərif qeyd edib */
string input = Console.ReadLine();
if (int.TryParse(input,out int checkNumber))
{
    /* əyər number type parse olsa bu blokdakı kod işləyəcək*/

    /* blok deyəndə  { } bu parantezlərin içindəki kod*/
}
else
{
    /* bu bloka rəqəm əvəzi hərif yazılsa parse edə bimıyəcək number type 
     və false alıb bura daxill olacayığ */
}

