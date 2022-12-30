using System;
namespace DataStructurePrograms
{
	public class InsertionSort
	{
		public void DisplayInsertionSort()
		{
			int[] arr = new int[5] { 22,56,87,43,11};
			int n= 5,i,j,val,flag;

			Console.WriteLine("Initial Array is :");
			for(i=0;i<n;i++)
			{
				Console.WriteLine(arr[i] + " ");
			}

			for (i = 0; i < n; i++)
			{
				val = arr[i];
				flag = 0;
				for (j=i-1;j>=0 && flag!=1;)
				{
					if (val < arr[j])
					{
						arr[j + 1] = arr[j];
						j--;
						arr[j + 1] = val;
					}
					else
					{
						flag = 1;
					}
				}
			}

			Console.WriteLine();
			Console.WriteLine("Sorted Arrat :");
			for(i=0;i<n;i++)
			{
				Console.WriteLine(arr[i] + " ");
			}
		}
	}
}

