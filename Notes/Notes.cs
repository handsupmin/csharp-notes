using System;
using static System.Console;

namespace Notes
{
    class Notes
    {
        // 열거 형식
        enum DialogResult { YES, NO, CANCEL, CONFIRM = 40, OK } // YES = 0, OK = 41

        static void Main(string[] args)
        {
            Test.test();
        }

        private void Note()
        {
            #region Casing Types
            // 1. PascalCasing(파스칼 케이싱)
            // 클래스, 열거형, 이벤트, 메서드 등의 이름을 만들 때 사용
            // 대문자로 시작
            // 복합어일 경우 중간에 시작하는 새로운 단어는 대문자
            //   예) UtilityBox, MainFrame

            // 2. CamelCasing(카멜 케이싱)
            // 메서드의 매개변수의 이름에 적용
            // 첫번째 문자는 소문자, 복합어일 경우 파스칼 케이싱과 동일하게 적용
            // 동일한 이름을 가지는 두 항목을 구분하는 용도로도 사용
            //   예) utilityBox, mainFrame

            // 3. SnakeCasing(스네이크 케이싱)
            // 단어를 _로 나눔
            // 보통 파일명에 많이 쓰임
            //   예) user_list , new_todo_list
            #endregion

            #region 변수, 상수 선언
            // 변수
            float floatA = 3.14159265358979f; // float은 뒤에 f를 붙인다.
            double doublaA = 3.14159265358979;
            decimal decimalA = 3.14159265358979m; // decimal은 뒤에 m을 붙인다.
            char charA = 'a'; // char은 따옴표(')
            string stringA = "this is string"; // string은 쌍따옴표(")

            var varA = 123;
            object objectA = 123;
            // var과 object의 차이점
            // var은 컴파일러가 데이터 형식 파악 후 varA에 123을 담아 stack에 올림
            // object는 CLR이 123을 박싱해서 힙에 넣고, objectA가 힙을 가리키도록 만듦

            // Nullable
            int? nullableIntA = null;
            WriteLine(nullableIntA.HasValue); // False
            nullableIntA = 34;
            WriteLine(nullableIntA.HasValue); // True
            WriteLine(nullableIntA.Value); // 34

            // 상수
            const double PI = 3.14159265358979;
            #endregion

            #region 형 변환
            // 부동 소수점 형식(float, double, decimal) 정밀성 손상 주의
            // overflow, underflow 주의
            // 부동 소수점 -> 정수: 소수점 버림
            // 문자 -> 숫자
            int stringToInt = int.Parse("12345");
            // 숫자 -> 문자
            string intToString = stringToInt.ToString();
            #endregion

            #region 열거형 사용
            DialogResult dialogResult = DialogResult.YES;
            WriteLine($"{(dialogResult == DialogResult.YES ? "Yes" : "No")}");
            #endregion

            #region 문자열
            // 찾기
            string stringTester = "Hello, Good Morning!";

            // IndexOf()
            WriteLine($"IndexOf 'Good' : {stringTester.IndexOf("Good")}"); // 7
            WriteLine($"IndexOf 'o' : {stringTester.IndexOf("o")}"); // 4

            // LastIndexOf()
            WriteLine($"LastIndexOf 'Good' : {stringTester.LastIndexOf("Good")}"); // 7
            WriteLine($"LastIndexOf 'o' : {stringTester.LastIndexOf("o")}"); // 13

            // StartsWith()
            WriteLine($"StartsWith 'Hello' : {stringTester.StartsWith("Hello")}"); // True
            WriteLine($"StartsWith 'Good' : {stringTester.StartsWith("Good")}"); // False

            // EndsWith()
            WriteLine($"EndsWith 'Morning!' : {stringTester.EndsWith("Morning!")}"); // True
            WriteLine($"EndsWith 'Good' : {stringTester.EndsWith("Good")}"); // False

            // Contains()
            WriteLine($"Contains 'Good' : {stringTester.Contains("Good")}"); // True
            WriteLine($"Contains 'Nice' : {stringTester.Contains("Nice")}"); // False

            // Replace()
            WriteLine($"Replace 'Good' with 'Great' : {stringTester.Replace("Good", "Great")}"); // Good -> Great

            // 변형
            // ToLower()
            // ToUpper()
            // Insert(index, string)
            // Remove(startIndex, endIndex)
            // Trim()
            // TrimStart()
            // TrimEnd()

            // 분할
            // Split(string[] seperator, options)
            string[] stringArr = stringTester.Split(new string[] { " " }, StringSplitOptions.None);
            foreach (string elementStringArr in stringArr)
                WriteLine($"{elementStringArr}");
            // SubString(startIndex, endIndex)

            // Formatting
            // {첨자, 맞춤: 서식 문자열}
            // 첨자:index
            // 맞춤: -5(왼쪽 5칸 맞춤), 7(오른쪽 7칸 맞춤)
            // 서식 문자열: D(10진수), X(16진수), N(콤마로 묶어 표현), F(고정소수점), E(지수)
            // {0, -5: D4}: 10진수를 4자리 까지 표현
            #endregion

            #region 연산자
            // 조건 연산자
            // 조건식 ? 참 : 거짓
            int conditionalOperatorInt = 30;
            string conditionalOperatorResult = conditionalOperatorInt == 30 ? "True" : "False";

            // null 연산자
            // ?.
            // 객체가 null이면 null을 반환, 아니면 .뒤에 지정된 멤버 반환
            nullableIntA?.ToString();

            // null 병합 연산자
            // ??
            // 왼쪽 피연산자가 null이 아니면 왼쪽 피연산자를 반환, null이면 오른쪽 피연산자를 반환
            WriteLine($"{(nullableIntA ?? 0)}");
            #endregion

            #region 조건문
            // if () - else if () - else
            if (floatA > 0)
                WriteLine("bigger than 0");
            else if (floatA == 0)
                WriteLine("0");
            else
                WriteLine("smaller than 0");

            // switch ()
            // 조건식은 정수, 문자열만 사용 가능
            int switchCondition = 3;
            switch (switchCondition)
            {
                case 1:
                    WriteLine("1");
                    break;
                case 2:
                    WriteLine("2");
                    break;
                case 3:
                    WriteLine("3");
                    break;
                default:
                    WriteLine("other");
                    break;
            }
            // C# 7.0부터는 데이터 형식을 조건으로 사용할 수 있음
            switch (objectA)
            {
                case int switchInt when switchInt >= 0: // when 사용 가능
                    WriteLine($"{switchInt} is bigger than 0.");
                    break;
                case int switchInt:
                    WriteLine($"{switchInt} is 0 or smaller than 0.");
                    break;
                case float switchfloat:
                    WriteLine($"{switchfloat}");
                    break;
                default:
                    WriteLine("other");
                    break;
            }

            // switch 식
            // case: =>
            // break: ,
            // default: _
            bool switchBool = true;
            int switchScore = 70;
            string switchGrade = switchScore switch
            {
                90 when switchBool == true => "Fail",
                90 => "A",
                80 => "B",
                70 => "C",
                _ => "D"
            };
            #endregion

            #region 반복문
            // while () {}

            // do {} while();
            // do-while문에서 while문 뒤에는 반드시 세미콜론을 붙여줘야 함

            // for()

            // foreach(데이터형식 변수명 in 배열_or_컬렉션)
            #endregion

            #region 점프문
            // break
            // continue
            // return
            // throw
            
            // goto
            // 중첩된 반복문을 빠져나올 때 유용
            // goto EXAMPLE;
            // EXAMPLE:
            #endregion

            #region title
            #endregion

            WriteLine("");
        }
    }
}
