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
            #endregion

            #region title
            #endregion

            WriteLine("");
        }
    }
}
