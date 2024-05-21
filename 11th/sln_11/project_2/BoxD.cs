﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxD
    {
        // 일반적인 속성 생성 방법
        // get 접근자와 set 접근자를 사용하여 속성 선언
        // get 접근자는 필드를 읽어오고 (추출) 
        // set 접근자는 필드에 값을 할당 (저장) 
        // set 접근자 안에 value 키워드는 누구도 선언한 적 없지만 C# 컴파일러는 set 접근자의 암묵적 매개변수로 간주
        private int width;
        public int Width { // 속성 (속성의 이름은 대문자로 시작한다)
            get { return width; } 
            set {
                if (value > 0) width = value; 
                else Console.WriteLine("너비는 자연수를 입력해 주세요.");
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("높이는 자연수를 입력해 주세요.");
            }
        }

        public int Area() { return this.width * this.height; } // 인스턴스 메서드
        public BoxD(int width, int height) // 생성자
        {
            Width = width;
            Height = height;
        }
    }
}
