using System;

// README.md를 읽고 코드를 작성하세요.


int[] Scores = { 95, 87, 73, 65, 45, 30 };


Console.WriteLine("=== 성적 평가기 ===");

foreach (var score in Scores)
{
    Console.WriteLine($"{score}점: {GetGrade(score)} ({GetStatus(score)}) - {IsPassingGrade(score)}");
}



string GetGrade(int score) => score switch
{
    >= 90 and <= 100 => "A",
    >= 80 and < 90 => "B",
    >= 70 and < 80 => "C",
    >= 60 and < 70 => "D",
    >= 0 and < 60 => "F",
    _ => throw new NotImplementedException()
};


string GetStatus(int score) => score switch
{
    >= 95 and <= 100 => "최우수",
    >= 90 and < 95 => "우수",
    >= 70 and < 90 => "보통",
    >= 40 and < 70 => "노력 필요",
    < 40 => "재수강 권장",
    _ => throw new NotImplementedException()
};

string IsPassingGrade(int score) => score switch
{
    >= 60 and <= 100 => "합격",
    < 60 and >= 0 => "불합격",
    _ => throw new NotImplementedException()
};