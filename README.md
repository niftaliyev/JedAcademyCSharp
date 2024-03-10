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