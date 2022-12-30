using System;
namespace DataStructurePrograms
{
	public class BubbleSort
	{
		public void DisplayBubbleSort()
		{
			int[] arr = { 11, 22, 334, 54, 76 };
			int temp;

			for (int j = 0; j <= arr.Length - 2; j++)
			{
				for (int i = 0; i <= arr.Length - 2; i++)
					if (arr[i] > arr[i + 1])
					{
						temp = arr[i + 1];
						arr[i + 1] = arr[i];
						arr[i] = temp;
					}
			}


			Console.WriteLine("The sorted array: ");
			foreach (int p in arr)
			{
				Console.WriteLine(p);
			}

		}
	}
}
