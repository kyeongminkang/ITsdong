using System;
using System.Collections.Generic;
using System.Text;

namespace Ch18_04
{
    public class Piano
    {

        const int samplingRate = 22050;
        // 샘플링 : 1초동안 몇번 잘라서 표현해줄 지? 조각 몇개 낼 것인지?
        // 샘플링 높아야 튀는 음을 잡을 수 있음!
        // 디폴트 값 설정, 주파수 440은 라 정도, 길이는 1/4
        public static void Play(double frequency = 440, int duration = 250)
        {
            // 16비트
            short[] shortBuffer = new short[samplingRate * duration / 1000];

            // 슬라이스를 자연스럽게 하기 위함
            double angleIncrement = frequency / samplingRate;
            double angle = 0;

            // 원본 데이터를 알면 2배속, 0.5배속 식으로 컨트롤 할 수 있음
            for (int i=0; i<shortBuffer.Length; i++)
            {
                double sample;
                if (angle < 0.25)
                    sample = 4 * angle;
                else if (angle < 0.75)
                    sample = 4 * (0.5 - angle);
                else
                    sample = 4 * (angle - 1);

                shortBuffer[i] = (short)(32767 * sample);
                // 한 사이클

                angle += angleIncrement;

                while(angle > 1)
                {
                    angle -= 1;
                }
            }

            byte[] byteBuffer = new byte[2 * shortBuffer.Length];
            Buffer.BlockCopy(shortBuffer, 0, byteBuffer, 0,  byteBuffer.Length);
        }
    }
}
