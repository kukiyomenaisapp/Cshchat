﻿using System;
using KYapp.Cshchat;
using System.Threading.Tasks;
using System.Net.Http;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            YoutubeLive a = new YoutubeLive("5qap5aO4i9A");

            a.Begin(_OnComment);

            Console.ReadKey();
            a.End();
            Console.ReadKey();
        }

        public static void _OnComment(Comment comment)
        {
            Console.WriteLine(comment.text);
        }
    }
}
