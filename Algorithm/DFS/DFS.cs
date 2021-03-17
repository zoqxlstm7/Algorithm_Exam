using System;
using System.Collections.Generic;

namespace DFS
{
    /// <summary>
    /// 스택 자료구조를 활용
    /// </summary>
    class DFS
    {
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

            Dfs(1);

            // 출력
            // 1 2 3 6 7 4 5
        }

        static void Dfs(int x)
        {
            // 이미 방문한 노드라면 리턴
            if (check[x])
            {
                return;
            }

            // 방문 처리
            check[x] = true;
            Console.Write("{0} ", x);

            // 인접한 노드를 방문했는지 재귀적으로 검사
            for (int i = 0; i < a[x].Count; i++)
            {
                int y = a[x][i];
                Dfs(y);
            }
        }
    }
}
