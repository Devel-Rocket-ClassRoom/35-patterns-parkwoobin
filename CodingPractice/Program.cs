using System;

// README.md를 읽고 코드를 작성하세요.







object obj = "Hello";

if (obj is string str)
{
    Console.WriteLine(str); // "Hello"가 출력됩니다.
}
else
{
    Console.WriteLine("obj는 문자열이 아닙니다.");
}

object obj2 = 42;

if (obj2 is int num)
{
    Console.WriteLine(num); // 42가 출력됩니다.
    Console.WriteLine(num * num);
}
else
{
    Console.WriteLine("obj2는 정수가 아닙니다.");
}


PrintInfo(100);
PrintInfo(3.14);
PrintInfo("Hello");
PrintInfo(true);
PrintInfo(DateTime.Now);


void PrintInfo(object obj3)
{
    switch (obj3)
    {
        case string s:
            Console.WriteLine($"문자열: {s}, 길이: {s.Length}");
            break;
        case int n:
            Console.WriteLine($"정수: {n}, 2배: {n * 2}");
            break;
        case double d:
            Console.WriteLine($"실수: {d}");
            break;
        case bool b:
            Console.WriteLine($"불리언: {b}");
            break;
        case DateTime dt:
            Console.WriteLine($"기타 타입: {dt}");
            break;
        default:
            Console.WriteLine("알 수 없는 타입입니다.");
            break;
    }
}

CheckValue(0);
CheckValue("Hello");
CheckValue(null);
CheckValue(42);


void CheckValue(object obj)
{
    if (obj is 0)
    {
        Console.WriteLine($"값이 {obj}임");
    }
    else if (obj is "Hello")
    {
        Console.WriteLine($"값이 {obj}임");
    }
    else if (obj is null)
    {
        Console.WriteLine("값이 null임");
    }
    else
    {
        Console.WriteLine($"다른 값: {obj}");
    }
}

Console.WriteLine(GetDayType(DayOfWeek.Monday));    // "평일"이 출력됩니다.
Console.WriteLine(GetDayType(DayOfWeek.Saturday));    // "주말"이 출력됩니다.


string GetDayType(DayOfWeek day)
{
    return day switch
    {
        DayOfWeek.Saturday => "주말",
        DayOfWeek.Sunday => "주말",
        _ => "평일"     // _는 default와 동일하다
    };
}



Console.WriteLine(DescribeValue(42));
Console.WriteLine(DescribeValue(3.14159));
Console.WriteLine(DescribeValue("Hello"));
Console.WriteLine(DescribeValue(null));
Console.WriteLine(DescribeValue(true));

string DescribeValue(object obj) => obj switch
{
    int i => $"정수: {i}",
    double d => $"실수: {d}",
    string s => $"문자열: \"{s}\"",
    bool b => $"불리언: {b}",
    null => "null 값",
    _ => "알 수 없는 타입 (Boolean)"
};


Console.WriteLine($"95점: {GetGrade(95)}");
Console.WriteLine($"85점: {GetGrade(85)}");
Console.WriteLine($"75점: {GetGrade(75)}");
Console.WriteLine($"65점: {GetGrade(65)}");
Console.WriteLine($"55점: {GetGrade(55)}");

string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};


int[] temperatures = { -5, 5, 15, 25, 35 };
foreach (int temp in temperatures)
{
    Console.WriteLine($"{temp}도: {ClassifyTemperature(temp)}");
}

string ClassifyTemperature(int celsius) => celsius switch
{
    < 0 => "영하",
    < 10 => "추움",
    < 20 => "선선함",
    < 30 => "따뜻함",
    _ => "더움"
};



Console.WriteLine($"25살 유효한 나이: {IsValidAge(25)}");
Console.WriteLine($"-5살 유효한 나이: {IsValidAge(-5)}");
Console.WriteLine($"15살 청소년: {IsTeenager(15)}");
Console.WriteLine($"25살 청소년: {IsTeenager(25)}");


bool IsValidAge(int age) => age switch
{
    >= 0 and <= 150 => true,
    _ => false
};

bool IsTeenager(int age) => age switch
{
    >= 13 and <= 19 => true,
    _ => false
};


Console.WriteLine($"토요일 주말: {IsWeekend(DayOfWeek.Saturday)}");
Console.WriteLine($"월요일 주말: {IsWeekend(DayOfWeek.Monday)}");
Console.WriteLine($"'a' 모음: {IsVowel('a')}");
Console.WriteLine($"'b' 모음: {IsVowel('b')}");

bool IsWeekend(DayOfWeek day) => day switch
{
    DayOfWeek.Saturday or DayOfWeek.Sunday => true,
    _ => false
};
bool IsVowel(char c) => c switch
{
    'a' or 'e' or 'i' or 'o' or 'u' or
    'A' or 'E' or 'I' or 'O' or 'U' => true,
    _ => false
};


Console.WriteLine($"\"Hello\" not null: {IsNotNull("Hello")}");
Console.WriteLine($"null not null: {IsNotNull(null)}");
Console.WriteLine($"\"Hi\" not empty: {IsNotEmpty("Hi")}");
Console.WriteLine($"\"\" not empty: {IsNotEmpty("")}");

bool IsNotNull(object obj) => obj is not null;
bool IsNotEmpty(string str) => str is not "";


int[] numbers = { 0, 5, 42, -3, 100, -50 };
foreach (int n in numbers)
{
    Console.WriteLine($"{n}: {ClassifyNumber(n)}");
}


string ClassifyNumber(int n) => n switch
{
    < 0 and >= -9 => "한 자리 음수",
    0 => "영",
    > 0 and < 10 => "한 자리 양수",
    >= 10 and < 100 => "두 자리 양수",
    _ => "그 외"
};


Console.WriteLine($"Janet: {IsJanetOrJohn("Janet")}");
Console.WriteLine($"john: {IsJanetOrJohn("john")}");
Console.WriteLine($"Mike: {IsJanetOrJohn("Mike")}");

bool IsJanetOrJohn(string name) =>
    name.ToUpper() is var upperName && (upperName == "JANET" || upperName == "JOHN");


var people = new[]
{
    new Person { Name = "철수", Age = 15 },
    new Person { Name = "영희", Age = 30 },
    new Person { Name = "할머니", Age = 70 }
};

foreach (var person in people)
{
    Console.WriteLine($"{person.Name}은 {DescribePerson(person)}");
}
string DescribePerson(Person p) => p switch
{
    { Age: < 18 } => "미성년자",
    { Age: >= 18 and < 65 } => "성인",
    { Age: >= 65 } => "노인",
    _ => "알 수 없는 나이"
};
Console.WriteLine(Greet(new Person { Name = "철수", Age = 15 }));
Console.WriteLine(Greet(new Person { Name = "영희", Age = 30 }));

string Greet(Person p) => p switch
{
    { Name: "철수" } => "안녕, 철수!",
    { Name: "영희" } => "안녕하세요, 영희님",
    _ => "안녕하세요!"
};

foreach (var p in people)
{
    Console.WriteLine($"{p.Name}: {DescribeDetailed(p)}");
}

string DescribeDetailed(Person p) => p switch
{
    Student { School: var school, Age: var age } => $"{age}세 학생, {school} 재학",
    Employee { Company: var company, Age: var age } => $"{age}세 직장인, {company} 근무",
    _ => "알 수 없는 사람"
};


var points = new[] { (0, 0), (3, 0), (0, 5), (2, 3), (-2, 3), (-2, -3), (2, -3) };
foreach (var (x, y) in points)
{
    Console.WriteLine($"({x}, {y}): {ClassifyPoint(x, y)}");
}

string ClassifyPoint(int x, int y) => (x, y) switch
{
    (0, 0) => "원점",
    (0, _) => "y축 위",
    (_, 0) => "x축 위",
    ( > 0, > 0) => "1사분면",
    ( < 0, > 0) => "2사분면",
    ( < 0, < 0) => "3사분면",
    ( > 0, < 0) => "4사분면",
};

string[] seasons = { "봄", "여름", "가을", "겨울" };
foreach (var season in seasons)
{
    Console.WriteLine($"{season} 낮: {GetTemperatureDescription(season, true)}");
    Console.WriteLine($"{season} 밤: {GetTemperatureDescription(season, false)}");
}

string GetTemperatureDescription(string season, bool isDaytime) => (season, isDaytime) switch
{
    ("봄", true) => "봄 낮: 따뜻한 낮",
    ("봄", false) => "봄 밤: 선선한 밤",
    ("여름", true) => "여름 낮: 무더운 낮",
    ("여름", false) => "여름 밤: 열대야",
    ("가을", true) => "가을 낮: 선선한 낮",
    ("가을", false) => "가을 밤: 쌀쌀한 밤",
    ("겨울", true) => "겨울 낮: 추운 낮",
    ("겨울", false) => "겨울 밤: 매서운 밤",
    _ => "알 수 없는 계절 또는 시간"
};

int[] numb = { 0, 4, 7, -6, -3 };

foreach (int n in numb)
{
    Console.WriteLine($"{n}: {DescribeNumber(n)}");
}


string DescribeNumber(int n) => n switch
{
    0 => "영",
    > 0 when n % 2 == 0 => "양수 짝수",
    > 0 when n % 2 != 0 => "양수 홀수",
    < 0 when n % 2 == 0 => "음수 짝수",
    < 0 when n % 2 != 0 => "음수 홀수",
    _ => "알 수 없는 숫자"
};



Product[] products = new[]
{
    new Product { Name = "마우스", Price = 25000, Stock = 0 },
    new Product { Name = "키보드", Price = 80000, Stock = 5 },
    new Product { Name = "모니터", Price = 300000, Stock = 20 },
    new Product { Name = "USB", Price = 5000, Stock = 100 }
};


foreach (var product in products)
{
    Console.WriteLine($"{product.Name}: {GetProductStatus(product)}");
}


string GetProductStatus(Product p) => p switch
{
    { Stock: 0 } => "품절",
    { Stock: < 10 } when p.Price > 10000 => "재고 부족 (고가 상품)",
    { Stock: < 10 } => "품절",
    { Price: > 50000 } => "프리미엄 상품",
    _ => "일반 상품"
};


var characters = new Character[]
{
    new Character { Health = 0, Mana = 50, IsInCombat = false },
    new Character { Health = 15, Mana = 30, IsInCombat = true },
    new Character { Health = 50, Mana = 0, IsInCombat = true },
    new Character { Health = 90, Mana = 85, IsInCombat = false },
    new Character { Health = 60, Mana = 40, IsInCombat = true }
};

foreach (var character in characters)
{
    Console.WriteLine($"캐릭터{characters} (HP: {character.Health}, MP: {character.Mana}): {GetCharacterStatus(character)}");
}


string GetCharacterStatus(Character c) => c switch
{
    { Health: 0 } => "사망",
    { Health: < 20, IsInCombat: true } => "위험 (전투 중)",
    { Health: < 20 } => "체력 낮음",
    { Mana: 0, IsInCombat: true } => "마나 고갈 - 물리 공격만 가능",
    { Mana: >= 80, Health: >= 80 } => "최상의 상태",
    { IsInCombat: true } => "전투 중",
    _ => "일반"
};




class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Student : Person
{
    public string School { get; set; }
}

class Employee : Person
{
    public string Company { get; set; }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}

class Character
{
    public int Health { get; set; }
    public int Mana { get; set; }
    public bool IsInCombat { get; set; }
}