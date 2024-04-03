## 1) C# nədir ? ##
> C# Microsoft tərəfindən 2001-ci ildə yaradılan obyekt yönümlü proqramlaşdırma dilidir. C# proqramlaşdırma dili C və C++ dillərinin üstün tərəflərini alaraq 
> yaradılıb. Hazırda .Net platformunda ən çox istifadə edilən proqramlaşdırma dilidir. C# ilə web proqramlaşdırma,oyun proqramlaşdırma,masaüstü proqramlar 
> yazmaq və hətta mobile proqramlaşdırma da mümkündür.

## 2) Sinif (class) nədir? ##
> Siniflər dəyişənlərı,metodları,propertiləri yığdığımız bir yerdir. Bu metodlari,dəyişənləri istifadə etmək üçün isə həmin sinifdən obyekt yaradılmalıdır.
> Sinifə bir nümunə olaraq İnsanı göstərə bilərik.
> İnsandakı xüsusiyyətlər məs. göz rəngi,adı,yaşı dəyişənlərimiz,onun danışması,gülməsi,qaçması kimi feili hərəkətləri isə metodlarımız olsun.
> Hər insan bu xüsusiyyətlərə fərd olaraq sahibdir. Proqramlaşdırmada da siniflərdə yazdığımız xüsusiyyətlər, metodlar obyektlərə aid edilir.Obyektlər bizim
> fərdlərimizdir.
```
class Person{
  public string eyeColor;
  public string name;
  public int age;
  
  void Talk(){
    //codes
  }
  
  void Laugh(){
    //codes
  }
}
```

## 3) Obyekt (object) nədir? ##
> Obyekt bir sinifdən yaradılan və yaddaşda yer tutan bir verilən strukturudur. Obyekt sinifin nümunəsidir,sinifin içərisində tanımlanılan metodlara,
> dəyişənlərə və s. obyektlər vasitəsilə çatmaq mümkündür.Obyektlər siniflərdə yazdığımız xüsusiyyətlərə,metodlara sahib olur. 
> Sinifdən bir obyekt yaratmaq üçün `new` açar sözündən istifadə edilir.
> Məsələn aşağıdakı nümunədə `Person` sinifə məxsus `age` dəyişəni `obj` obyekti vasitəsi ilə çağırılıb və 5 dəyəri mənimsədilib.

  ```
    Person obj = new Person();
    obj.age = 5;
  ```
  

## 4) C# propertilər nədir? ##
> C#-da propertilər dəyişənlərə çox bənzəyir lakin adi dəyişənlərdən fərqli olaraq get və set bloklarına malikdir. 
> Bu bloklar dəyərin oxunması və mənimsədilməsi zamanı çalışır.
> Məsələn , propertiyə dəyər mənimsədərkən set blokları çalışır , set blokları vasitəsi ilə mənimsədilən dəyər üzərində müəyyən əməliyyatlar icra etdikdən
> sonra dəyəri get bloklarına ötürüb ekrana çap edə bilərik.

```
  class Test{
    private int number;
    public int Number {get{ return number; } set{ number = value;} } //value menimsetdiyimiz deyeri (12) temsil edir
  }
  
  static void Main(string[] args){
    Test test = new Test();
    test.Number = 12; // Set blokları çalışdı
    Console.WriteLine(test.Number); // Get blokları çalışdı
  }
  
```

## 5) Value type və referance type nədir və hansılardır? ##
> C#-da tiplər yaddaşda tutduğu yerə görə 2 yerə bölünür _value tiplər_ və _referance tiplər_.
> Value typelar yaddaşda stack adlanan hissədə tutulur. Value typelar aşağıdakılardır:
* int                                    
* double                   
* decimal                  
* float                      
* byte
* bool
* char
* struct
* enum
> Referans tiplər isə yaddaşın heap hissəsində saxlanılır, lakin onların stackda unikal adresləri olur,heapdakı referans tipə keçid məhz stack bölməsindəki unikal adresdən keçir. Referans typelar əsasən `new` açar sözü ilə yaradılan obyektlərdir.
* Object
* Class
* Interface
* string
* array (hər tipdən olan arraylar bura daxildir)
* List


```
int num1;
int num2 = 12;

num1 = num2; // num1-in yeni dəyəri 12 olacaq
num2 = 19;  // num2-nin yeni dəyəri 19 olacaq amma num1-in dəyəri dəyişməyəcək,çünki o bir value typedır!
```

```
string[] cities = new string[]{"Bakı","Masallı","Sumqayıt"}; // array referans tipdir heapda saxlanılacaq,amma unikal adresi stackdadır

string[] cities2 = new string[]{"Gəncə","Lənkəran","Şamaxı"}; // başqa bir referans tipli obyekt

cities = cities2; // İki referansı tipi bir-birinə mənimsədən zaman onların stackdəki adreslərini eyni referansa yönəltmiş oluruq
```

cities[0] = "Naxçıvan";
```
> Bu zaman hər iki adres eyni referansı göstərdiyindən `cities[0]="Naxçıvan"` yazdıqdan sonra eyni dəyər `cities2` arrayında da dəyicək.
```
Console.WriteLine(cities2[0]); // Naxçıvan
```
> `cities` arrayının heapdakı referansına ({"Bakı","Masallı","Sumqayıt"}) nə olacaq ? Bu zaman Garbage Collector dediyimiz obyekt heapda adresi olmayan bütün referansları siləcək.

```

## 6) Static metodlar nədir? ##
> Static metodlar obyekt ilə deyil birbaşa sinifin adı ilə müraciət edilən metodlardır. Bu metodlar çağırılan zaman obyekt yaradılmadığından constructor işə düşməyəcək.
> Static metodlar `static` açar sözü ilə yaradılır və yalnız static classlarda mövcud ola bilir.

```
public static class Math{
  public static int Sum(int num1,int num2){
    return num1+num2;
  }
}
```
> Çağırılan zaman aşağıdakı şəkildə sinifin adı ilə çağırılır.
```
Math.Sum(2,3);
```

## 5) OOP prinsipləri hansılardır? ##
> Obyekt yönümlü proqramlaşdırmada 4 əsas prinsip mövcuddur.

* Encapsulation (Kapsullama)
* Inheritance (Mirasalma)
* Abstraction (Mücərrədlik)
* Polymorphism (Çox yönümlülük)

***Encapsulation (Kapsullama)*** <br>
Encapsulation siniflərdə yazdığımız dəyişənlərin əlçatılabilirliyini propertilər vasitəsilə məhdudlaşdırmaq və istifadəçilərin hər dəyişənə rahatlıqla çata
bilməsinə maneə olmaq məqsədi ilə istifadə edilir.
Məsələn, aşağıdakı nümunədə: 
```
 Person obj = new Person();
 obj.age = 5;
```
`age` dəyişəninə 5 dəyərini mənimsətdik. Burada hər şey normal görsənir,yaxşı bəs əgər 5 deyil -5 mənimsətsəydik?
Texniki baxımdan bunu etməyimiz heç bir xəta səbəbi olmayacaqdı,çünki `age` dəyişənimizin tipi `int`-dir və `int` mənfi dəyərlər ala bilir.
Amma insanın yaşı mənfi ola bilməz. Belə halların qarşısını almaq üçün `age` dəyişənini kapsullayaq.

```
class Person{
    private int age;
    public int Age 
    {
      get{ return  age; } 
      set
      {
        if(value > 0)
          age = value;
      }
   } 
}
```
Bildiyimiz kimi propertilerdeki set bloku dəyər mənimsədən zaman işə düşür,biz də həmin dəyərin 0-dan böyük olduğu vəziyyəti yoxlayıb neticeni ona görə qaytardıq,artıq bu halda istifadəçi `age` dəyişəninə mənfi dəyərlər mənimsədə bilməz (əks halda 0 nəticəsi alacağıq).

***Inheritance (Mirasalma)*** <br>
Bizim siniflərimiz sayca çox olacaq.Bənzər xüsusiyyətlərə sahib siniflərin içərisində eyni kodu təkrar-təkrar yazmaq yerinə həmin kodları üst sinifdən (Base class) miras almaq daha əlverişli olacaq.
Məsələn,
```
class Employee{
  public string eyeColor;
  public string name;
  public int age;
}

class Manager{
  public string eyeColor;
  public string name;
  public int age;
}


```
şəklində `Employee` və `Manager` sinifləri üçün dəyişənləri bu şəkildə yaratmağımızda heç bir problem yoxdur amma fikir verdinizsə eyni kodları yazdıq üstəlik bu xüsusiyyətlər işçi ya da menecer olmağından asılı olmayaraq hər bir insana aiddir. İndi isə bu kodları qısaldaq :
```
class Person{
  public string eyeColor;
  public string name;
  public int age;
}

class Employee:Person{
}

class Manager:Person{
}

```
daha əvvəl `Employee` və `Manager` siniflərində yazdığımız eyni kodların hər insana məxsus olduğunu demişdik,indi o dəyişənləri `Person` adında bir sinifə yazıb yuxarıdakı qayda ilə həm `Employee` həm də `Manager` siniflərində istifadə edə bilərik. Beləliklə, `Employee` və `Manager` sinifləri `Person` sinifindən onun xüsusiyyətlərini miras almış oldu.

Onu da unutmayaq ki,alt siniflər (nümunədə `Employee` və `Manager`) yalnız bir __sinifdən__ miras ala bilər.

***Abstraction (Mücərrədlik)*** <br>
Abstract siniflər üst sinif (Base class) olaraq istifadə edilən mücərrəd siniflərdir. Abstract siniflərin bəzi xüsusiyyətlərinə baxaq.

* Üst sinifdə var olan metod və propertilərin alt siniflərə görə müxtəlif cür işlədiyi vəziyyətlərdə istifadə olunur.
* Bu siniflərdə _abstract_ açar sözü ilə işarələnən metodlar və propertilər onu miras alan alt siniflər tərəfindən mütləq implement olunmalıdır!
* Abstract metodlar və propertilər abstract siniflərdə yazılmalıdır.
* Abstract metodlar və propertilər private ola bilməz!
* Abstract metodlar yazıldığı üst siniflərdə yalnız imza hissəsi ilə qeyd olunur. Onların tam hissəsi implement olunduqları alt siniflərdə yazılır. 
* Abstract siniflərdə abstract olmayan metodlar da yazıla bilər.
* Abstract siniflərdən obyekt yaradıla bilməz!

Nümunə:
```
abstract class Car{
  public abstract void Start();
}

class Audi:Car{
 public override void Go()
 {
    throw new NotImplementedException();
 }
}

```
Baxmayaraq ki , abstract siniflərdən obyekt yaranmır amma onlar obyekt yaradarkən referans olaraq istifadə edilə bilir.
```
Car audi = new Audi();
```

***Polymorphism (Çox yönümlülük)*** <br>
Üst sinifin referans , onun alt siniflərinin isə obyekt olaraq yaradıldığı vəziyyətdir.

Məsələn:
```
  Animal a1 = new Bird();
```
bu nümunədə `Animal` sinifini üst sinif olaraq `Bird` sinifini isə onun alt sinifi olaraq düşünsək, yuxarıdakı kimi obyekt yaratmaq mümkündür.
Amma bunun tərsi mümkün deyil, eyni ilə hər quşun heyvan olması,amma hər heyvanın quş olmaması kimi.
```
Bird a1 = new Animal(); //error
```
nümunələri artırmaq olar:
```
Animal a2 = new Tiger();
Animal a3 = new Cat();
```
Burada üst sinif olan `Animal` hər obyektə görə müxtəlif davranış göstərir yəni çox yönümlü olur. 


## 6) C#-da hansı növ siniflər (class) mövcuddur? ##
> C#-da aşağıdakı növdə siniflər (class) mövcuddur:
* Abstract class
* Static class
* Sealed class
* Partial class

(Hər biri haqqında ətraflı məlumat verilib)

## 7) Abstract classlar və interfacelər arasındakı fərqlər nələrdir? ##

Abstract class| Interface
------------- | -------------
Constructoru olur  | Constructoru olmur
Static dəyərlər ala bilər | Static dəyərlər ala bilməz
Abstract classlardakı elementlər bütün access modifierslərlə işlənə bilər (abstract metodlar private ola bilmaz) | Access modifiersi yalnız public ola bilər
Bir sinif yalnız bir abstract classı miras ala bilər | Bir sinif birdən çox interfeysi miras ala bilər
Bir çox sinif eyni tipdən və ortaq davranış göstərirsə abstract sinif base class olaraq istifadə edilər | Bir çox sinif yalnız ortaq metodlar istifadə edirsə interfeys istifadə etmək lazımdır
Abstract classlar metod,properti,fields,consts və s. elementlər ala bilir | Interfeyslər yalnız metodlarla işlənir
Abstract classdan miras alan alt siniflər yalnızca bu sinifdəki abstract açar sözlü metodları implement etmelidir | Interfeysdən miras alan siniflər interfeysin bütün metodlarını implement etmelidir

## 8) Virtual metodlar nədir? ##
> Bir metodun ``virtual`` açar sözü ilə işarələnməsi o metodun alt siniflərdə dəyişdirilib fərqli davranış göstərə biləcəyi mənasına gəlir.

```
 public class Car
 {
    public virtual void Start()
    {
        Console.WriteLine("Car started");
    }
 }

 public class Audi : Car
 {
    public override void Start()
    {
        Console.WriteLine("Audi started");
    }
 }
```
> Yuxarıdakı nümunədə base classda olan `Start` metodu onun alt sinifində fərqli şəkildə davranış göstərdi, bunun üçün `override` açar sözündən istifadə etmək lazımdır.
> Onu da unutmayaq ki, metodu `override` etmək kimi bir məcburiyyətimiz yoxdur,yəni `Start` metodunu `Audi` sinifində dəyişmək kimi bir məcburiyyətimiz yox idi.

## 9) Metodun override edilməsi nədir? ##
> Metodun override edilməsinə metodun əzilməsi də deyirlər, mənası da üst siniflərdə olan metodun alt siniflərdə dəyişdirilərək istifadə edilməsidir. 
> Unutmayaq ki,yalnız `virtual` açar sözü ilə işarələnmiş metodları əzə (dəyişdirə) bilərik.

## 10) Metodun overload edilməsi nədir? ##
> Bu sual metodun override edilməsi ilə qarışdırılmamalıdır. Override metodu əzmək idisə, overload metodun artıq yüklənməsidir.
> Yəni bir sinifdə var olan bir metodu həmin sinifdə eyni ad altında yenidən yarada bilərik amma necə?
> Bunun üçün bəzi şərtlər var təbii ki birəbir eyni imza ilə 2 eyni metodu yarada bilmərik.

```
class Math{
  public void Sum(int a,int b){
    //code
  }

  public void Sum(int a,int b){ //error 2 eyni imzaya sahib metod ola bilməz
    //code
  }
}
```
> O zaman nə edəcəyik,təbii ki, imzalarını dəyişdirəcəyik.
> Məsələn, birinci metod 2 parametr alıbsa 2-ci Sum metodu 3 parametr ala bilər yaxud ilk metodun parametrləri `int` tipində olub 2-ci metodun parametrləri `double` ola bilər. Bu hallarda eyni ad ilə xəta almadan metodlarımızı yarada bilərik,buna da metodun overload edilməsi deyilir.

```
class Math{
  void Sum(int a, int b)
  {
  //code
  }
  void Sum(int a, int b, int c)
  {
  //code
  }
}
```
yaxud
```
class Math{
  void Sum(double a, double b)
  {
  //code
  }
  void Sum(int a, int b)
  {
  //code
  }
}
```
> hətta geri dönüş tipini də dəyişərək etmək mümkündür
```
class Math{
  void Sum(double a, double b)
  {
  //code
  }
  int Sum(int a, int b)
  {
  //code
  }
}
```

## 12) Sealed classlar nədir? ##
> `Sealed` açar sözü ilə tanımlanmış classlar miras alma xüsusiyyətini bloklayır. Yəni bu şəkildə tanımladığımız classlardan artıq miras ala bilmərik.

```
public sealed class Car{
  //methods & properties
}

public class Audi:Car{ //error sealed classlardan miras almaq olmaz
}
```

## 13) Access modifierlar nədir və hansılardır? ##
> Access Modifier-lar kodda xarici müdaxilənin sərhədlərini müəyyən etmək üçün istifadə olunan əsas ifadələrdir. 
> C#-da aşağıdakı access modiferlar mövcuddur:
* Private — Bir dəyərin private olaraq tanımlanması , o dəyərin yalnız aid olduğu sinifdən əlçatılan olması mənasına gəlir.
* Public — Bir dəyərin public olaraq tanımlanması , o dəyərin istənilən yerdən əlçatılan olması deməkdir. Public-də məhdudiyyət yoxdur.
* Protected — Bir dəyərin protected olaraq tanımlanması , o dəyərin aid olduğu sinifdən və o sinifi miras alan alt siniflərdən əlçatılan olması deməkdir.
* Internal — Bir dəyərin internal olaraq tanımlanması , o dəyərin yalnız eyni proyektdən əlçatılan olması deməkdir.
* Protected Internal — Bir dəyərin protected internal olaraq tanımlanması , o dəyərin aid olduğu sinif , onun alt sinifləri və hətta onun digər proyektdəki alt sinifindən əlçatılan olması deməkdir.


## 26) Ref və out açar sözləri arasındakı fərq nədir? ##
> Ref açar sözü referans sözünün qısaltmasıdır,parametrlərin referansını metoda vermək üçün istifadə edilir.Bir metoda parametr ötürdüyümüz zaman yalnız dəyəri kopyalanar, ötürdüyümüz parametrin referansını kopyalamaq üçün `ref` açar sözündən istifadə edə bilərik.

> Əvvəlcə ref istifadə etmədən kodu aşağıdakı şəkildə yazaq:
```
int a = 41;
Console.WriteLine(a); // 41

ChangeNumber(a);
Console.WriteLine(a); // 41

void ChangeNumber(int num){
    num = 100;
}
```
> Metod vasitəsilə dəyişənin qiymətini dəyişdirmək istəsək bu zaman ref açar sözündən istifadə edə bilərik. Biz a dəyişəninə reference-nı(adressini) metoda ötür demiş oluruq.

```
int a = 41;
Console.WriteLine(a); // 41

ChangeNumber(ref a);

Console.WriteLine(a); // 100

void ChangeNumber(ref int num){
    num = 100;
}
```

> Out açar sözü də eyni işi görür, yəni parametrin referansını metodlara verməkdə istifadə olunur. `out` və `ref` -in təməl fərqi odur ki, ref açar sözünü istifadə ediriksə,parametrin başlanğıc dəyəri verilməlidir,out-da isə belə bir məcburiyyət yoxdur.
```
int a;

ChangeNumber(out a);

Console.WriteLine(a); // 100

void ChangeNumber(out int num)
{
    num = 100;
}
```

## 27) Const və readonly arasındakı fərq nədir? ##
> Bütün proqram boyunca dəyərin sabit qalmasını istədiyimiz dəyişənləri tanımlayan zaman `const` və ya `readonly` açar sözlərindən istifadə edə bilərik. 
> Hər ikisinin gördüyü iş eynidir,yəni sabit parametr yaratmağımıza kömək edir,amma aralarında bəzi fərqlər mövcuddur.

* Const
  * Tanımlandığı anda dəyəri verilməlidir
  * Const ilə tanımlanan dəyişənlər statikdir və onlara sinifin adı ilə müraciət olunur
  * Classdan yaradılmış obyekt vasitəsilə müraciət edilə bilməz

* Readonly
  * Dəyərini tanımladıqdan sonra metod yaxud constructorda verə bilərik
  * Classdan yaradılan obyekt ilə müraciət edilə bilir
  
```
public class Example
{
    public const float PI = 3.14f; // mütləq dəyəri verilməlidir
    public readonly string variable; // dəyəri constructorda verildi

    public Example(string variable)
    {
        this.variable = variable;
    }
    public Example(){}
}
```
> Bu dəyişənlərə müraciət edən zaman :
```
Example.PI // const dəyər sinifin adı ilə çağırılır
Example obj = new();
obj.variable; // readonly dəyər obyekt ilə çağırılır
```
> Hər iki dəyişən də sabit olduğundan onların dəyərini dəyişə bilmərik!

## 28) Birdən çox catch bloku çalışa bilərmi? ##
> Try bloku ilə birlikdə birdən çox catch bloku tanımlana bilər ,amma _sadəcə exceptionu tutan ilk catch bloku çalışacaq_. Əgər proqram exception atarsa, bu exception sıra ilə catch bloklarında yoxlanılacaq və yalnız uyğun catch bloku işə düşəcək, əgər heç bir catch bloku uyğun deyilsə, heç biri işə düşməyəcək.  
> Əgər uyğun bir exception üçün birdən çox catch bloku yazılarsa, bu zaman runtime error alacağıq.
```
try
{
    int a = 4;
    Console.WriteLine(a / 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex) // error eyni exception üçün birdən çox catch bloku yazıla bilməz 
{
    Console.WriteLine(ex.Message);
}

```

## 30) Constructor zənciri nədir? ##
> Constructor zənciri bir sinifin birdən çox constuctorundan birini çağıraraq bir constructordan digərinə keçmə əməliyyatıdır.

> C# -da bir constructordan digərinə keçmək üçün `base()` yaxud `this()` açar sözlərindən istifadə edilə bilər.

* `this()` açar sözü _bir class daxilindəki_ constructor metodlarda birindən digərinə parametr göndərmək üçün istifadə olunur
```
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string lastName)
    {
       this.LastName = lastName;
    }

    public Person(string firstName, string lastName) :this(lastName) // lastName diger constructora göndərilib orada dəyər alacaq
    {
        this.FirstName = firstName;
    }
}
```

* `base()` açar sözü isə adından da anlaşıldığı kimi base classın (üst sinifin) constructoruna parametr göndərmək üçün istifadə olunur.
 ```
class Employee : Person
{
    public Employee(string firstName, string lastName) : base(firstName, lastName) // üst sinifə ötürülüb orada dəyər alacaq
    {
    }
}
 ```

 ## 34) Array və ArrayList arasındakı fərqlər nələrdir? ##
> Array və ArrayList dataların toplanması üçün istifadə edilən tiplərdir.Hər ikisi birdən çox dataların toplanmasında istifadə edilsə də,fərqləri çoxdur.

* Arraylar
  * Əvvəlcədən müəyyən edilmiş tipdə,müəyyən edilmiş sayda məlumat toplayır
  * Array yaratmaq üçün mütləq arrayın saxlayacağı datanın tipi və saxlanılacaq məlumatların sayı əvvəlcədən müəyyən edilməlidir
  * Arraya data əlavə etmək yaxud çıxarmaq olmaz
  * Null dəyərlər ala bilməz
```
int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
```
* ArrayList
  * ArrayList üçün isə əvvəlcədən tip müəyyən edilmir və ArrayListlərin həcmi dinamikdir,yəni məlumat əlavə etdikcə yaxud sildikcə dəyişir
  * ArrayListə məlumat əlavə etmək yaxud çıxarmaq mümkündür
  * Null dəyərlər ala bilər
```
ArrayList numbers = new ArrayList();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
```
> ArrayListin performansı Arraya görə daha yavaşdır,həmçinin ArrayList məlumatları object tipində qəbul etdiyindən müxtəlif tipdən məlumatları saxlaya bilər.
> Digər tərəfdən arraylar seçilən tipdə məlumatları toplayır,hansının istifadə ediləcəyi ehtiyaca görə dəyişir.

## 35) Break və continue açar sözləri arasındakı fərqlər nələrdir? ##
> Break və continue açar sözləri dövrlərdə (for,while) istifadə edilirlər.

* Break açar sözü dövrü sonlandırır və dövrdən tamamilə çıxır.
```
for (int i = 0; i < 10; i++)
{
    if (i == 3)
        break; // 3-cü iterasiyada dövr tamamilə sonlanır
    Console.WriteLine(i); // 0 1 2
}
```
* Continue açar sözü isə dövrün cari iterasiyasını atlayır və növbəti iterasiyaya keçir.
```
for (int i = 0; i < 10; i++)
{
    if (i == 3)
        continue; // 3-cü iterasiya keçilir və dövr davam edilir
    Console.WriteLine(i); // 0 1 2 4 5 6 7 8 9
}
```

## 36) C# -da error handling (xeta idarəsi) üçün istifadə edilən açar sözlər hansılardır? ##
> Aşağıdakı açar sözlər C# -da error handling zamanı istifadə edilə bilər
* `try` xəta ehtimalı olan kod bu blokda yazılır
* `catch` try blokunda xəta baş verərsə burada yazdığımız kodlar çalışacaq
* `finally` xəta olub olmamasından asılı olmayaraq çalışacaq kod blokudur
* `throw` xəta yaratmaq üçün istifadə edilir (əsasən catch blokunda)
> Xəta baş verməsi anında xətanın idarə edilməsində istifadə edəcəyimiz açar sözlər bunlardır, nümunəyə baxaq:
```
try
{
  int a = 2;
  int b = 0;
  int c = a / b;
  Console.WriteLine(c);
}
catch (Exception ex)
{
  throw new Exception(ex.Message);
}
finally
{
   Console.WriteLine("BB");
}
```
## 37) C# -da komment əlavə etmənin yolları hansılardır? ##
* Single-Line Comment: Tək sətirlik komment üçün `//` simvolu istifadə edilir
```
// This is a single-line comment
```
* Multi-Line Comment: Çox sətirlik komment üçün `/* */` istifadə edilir
```
/*
This is
multi-line 
comment
*/
```
* XML Documentation Comments: Xml kodlarındakı commentlər üçün `///` istifadə olunur
```
/// <summary>
/// This is an XML documentation comment
/// </summary>
```

## 38) C# -da nullable tiplər necə istifadə edilir? ##
> Bildiyimi kimi C# -da value typelar `null` dəyərlər ala bilmir, nullable tiplər value typelara null dəyərlər ötürə bilməyimizi təmin edir və aşağıdakı kimi yazılır.

```
int a = null; // error value type null ola bilmez
Nullable<int> b = null; // okay
```
> Bu yazılışı daha da qısaldıb aşağıdakı kimi yaza bilerik
```
int? b = null;
```
> Bu nullable dəyişənlərinin dəyərinin olub olmadığını yoxlamaq üçün `HasValue` propertisindən istifadə edə bilərik
```
if(b.HasValue) // b null deyilsə true əks halda false
    // codes
```
> Dəyərini almaq üçün isə `Value` propertisindən istifadə ediə bilərik
```
if(b.HasValue)
    Console.WriteLine(b.Value);
```
> Bunlarla yanaşı onu da bilməkdə fayda var ki, `var` tipi heç vaxt null ola bilməz!

## 39) C# -da String və StringBuilder arasındakı fərq nədir? ##
* String mətn, text şəklində dəyərlər saxlamaq üçün istifadə etdiyimiz bir tipdir. Mətn tipli dəyərlərin içərisində axtarış, qarşılaşdırma və s. əməliyyatlar icrə edə bilərik.
* Amma `String` sinifi immutable (dəyişdirilə bilməz) olduğundan cari string tipli dəyişənimizdə etdiyimiz dəyişikliklər üçün yeni bir `String` obyekti yaradılır, dəyişikliklərimiz orada qeyd edilir və əvvəlki stringin referansı qırılır.
```
// String sinifi
string myString = "Salam, Dünya!";
myString = myString.Replace("Dünya", "C#"); // heapda yeni bir obyekt yaradıldı
Console.WriteLine(myString);
```
* `StringBuilder` sinifi də mətn tipli dəyərləri saxlamaq üçün istifadə edilir.
* Təməl fərq odur ki, `StringBuilder` sinifi, `String` kimi immutable deyil, yəni cari dəyərin üzərində dəyişikliklər etdiyimiz zaman yeni bir obyekt yaradılmır.
```
// StringBuilder sinifi
StringBuilder myStringBuilder = new StringBuilder("Salam, Dünya!");
myStringBuilder.Replace("Dünya", "C#"); 
Console.WriteLine(myStringBuilder.ToString());
```
* Bonus olaraq, `StringBuffer` sinifi haqqında da məlumat verək, demək olar ki, `StringBuilder` ilə eynidir.
* `StringBuffer`-in təməl fərqi sinxron şəklində çalışması və 2 threadın eyni vaxtda eyni metoda daxil olmasına icazə verməməsidir. 

## 40) Array.CopyTo() və Array.Clone() metodları arasındakı fərq nədir? ##
> Hər iki metod С# -da arrayları kopyalamaq üçün istifadə edilir
* `Array.CopyTo()` metodu əsas arraydakı elementləri seçdiyimiz arraya kopyalamaqda istifadə olunur
* Bu metodla seçdiyimiz arrayın tipini və həcmini ötürməliyik, əgər əsas arrayın həcmi seçdiyimiz arrayın həcmindən böyük olsa, ArgumentException xətasını alacağıq.
```
int[] currentArray = new int[] { 1, 2, 3 };
int[] selectedArray = new int[3]; // həcmi və tipi əsas arraydakılarla eyni olmalıdır

// System.Array.CopyTo() 
currentArray.CopyTo(selectedArray, 0);
Console.WriteLine(string.Join(", ", selectedArray)); // 1, 2, 3
```
> Əks halda
```
int[] currentArray = new int[] { 1, 2, 3 };
int[] selectedArray = new int[2]; // həcmi cari arraydakından aşağıdır

// System.Array.CopyTo() 
currentArray.CopyTo(selectedArray, 0); // ArgumentException
Console.WriteLine(string.Join(", ", selectedArray)); 
```
* `Array.Clone()` metodu isə əsas arrayın bir kopyasın yaradır və geriyə kopyasını yaratdığı arrayı dönür.
* Bu metod əsas arrayın bir kopyasını yaratdığından əsas arrayda ediləcək dəyişikliklərə məruz qalmayacaq.
```
int[] currentArray = new int[] { 1, 2, 3 };
int[] selectedArray = (int[])currentArray.Clone(); // həcmini ötürməyimizə ehtiyac yoxdur

Console.WriteLine(string.Join(", ", selectedArray)); // 1, 2, 3
```

## 41) C# -da extension metodlar nədir? ##
> Extension metodlar class ya da structu dəyişdirmədən onlara metod əlavə edə bilməyimizi təmin edir.
> Bəzi classlar əlçatılmaz ola bilər, həmin classların içərisinə müdaxilə etmədən onlara aid metodlar yaza bilərik.
* Extension metod yazmaq üçün bir neçə qayda var
  * Extension metodlar static classda static metod olaraq yazılmalıdır
  * Genişləndiriləcək class həmin extension metoda metodun ilk parametri olaraq verilib önünə this açar sözü ilə yazılmalıdır.
  * Extension metodda müəyyən edilmiş parametrlərdən yalnız 1-i this açar sözlə müəyyən edilə bilər.
> Bir extension metod nümunəsi yazaq, fərz edək ki, belə bir classımız var və biz o classa müdaxilə etmədən ona aid metod yazmaq istəyirik
```
class Math{
    public int Sum(int num1,int num2){
      return num1 + num2;
    }
}
```
> Indi extension metodu yazaq
```
public static class MathExtension{ // istediyimiz adı vere bilerik
    public static int Multiply(this Math math,int num1,int num2){ // ilk parametr genişledilecek class və önüne this açar sözü
      return num1 * num2;
    }
}
```
> Artıq classdan obyekt yaradılan zaman hər iki metoda çata bilərik
```
Math math = new Math();
math.Sum(3,4);
math.Multiply(4,2);
```
***Extension metodlar statik olaraq yazılmağına baxmayaraq obyekt adı ilə çağırılır***
> Extension metodlar daha çox C# -ın hazır metodlarına əlavə metod yazmaq istədiyimiz zaman source koda müdaxilə etmədən bunu etməyimizə imkan verir.