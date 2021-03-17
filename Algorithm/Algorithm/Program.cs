using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static int number = 7;
        static bool[] check = new bool[8];

        static List<int>[] a = new List<int>[8];

        static void Main(string[] args)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new List<int>();
            }

            // 1과 2를 연결
            a[1].Add(2);
            a[2].Add(1);
            // 1과 3을 연결
            a[1].Add(3);
            a[3].Add(1);
            // 2와 3을 연결
            a[2].Add(3);
            a[3].Add(2);
            // 2와 4를 연결
            a[2].Add(4);
            a[4].Add(2);
            // 2와 5를 연결
            a[2].Add(5);
            a[5].Add(2);
            // 4와 5를 연결
            a[4].Add(5);
            a[5].Add(4);
            // 3과 6을 연결
            a[3].Add(6);
            a[6].Add(3);
            // 3과 7을 연결
            a[3].Add(7);
            a[7].Add(3);
            // 6과 7을 연결
            a[6].Add(7);
            a[7].Add(6);

            // bfs 실행
            Bfs(1);
        }

        static void Bfs(int start)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            check[start] = true;

            // queue가 빌때까지 반복
            while (q.Count != 0)
            {
                int x = q.Dequeue();
                Console.Write("{0} ", x);
                for (int i = 0; i < a[x].Count; i++)
                {
                    int y = a[x][i];
                    if (!check[y])
                    {
                        q.Enqueue(y);
                        check[y] = true;
                    }
                }
            }
        }
    }
}
