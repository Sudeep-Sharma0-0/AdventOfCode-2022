using System.Collections.Generic;
using System;
using System.IO;

namespace Day1 {
	class MaxCalorieCalc {
		static void Main(string[] args) {
			string[] inputLines = File.ReadAllLines ("Day-1/input.txt");

			List<int> calorieList = new List<int> ();
			int elfId = 0, calorie = 0, totalCalories = 0;

			foreach (string line in inputLines) {
				if (line.Equals ("")) {
					calorieList.Add (calorie);
					calorie = 0;
					elfId++;
				} else calorie += Int32.Parse (line);
			}

			calorieList.Sort((a, b) => b.CompareTo(a));
			int maxCalorie = calorieList[0];
			for (int a = 0; a < 3; a++) totalCalories += calorieList[a];
			
			Console.WriteLine (maxCalorie);
			Console.WriteLine (totalCalories);
		}
	}
}