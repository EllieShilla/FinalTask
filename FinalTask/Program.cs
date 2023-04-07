// <copyright file="Program.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask
{
    using System;
    using FinalTask.Data;

    /// <summary>
    /// Our program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Our main entry point.
        /// </summary>
        /// <param name="args">Arguments to be passed to the application.</param>
        private static void Main(string[] args)
        {
            MainProgram mainProgram = new MainProgram();
            mainProgram.WorkProgram();

            Console.ReadLine();
        }
    }
}
