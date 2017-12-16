using System;
using BinaryTools;

class MainProgram
{
	static void Main()
	{
		VoxData vd = new VoxData(new BinaryReader("res/3x3x3.vox"));
		Console.Write(vd.Type);
		Console.WriteLine(vd.Version);
		Console.WriteLine(vd.NumModels);
		foreach(int[,] voxels in vd.Xyzas)
		{
			Console.WriteLine(voxels.Length);
			for(int i = 0; i < voxels.Length/4; i++) {
				Console.WriteLine("({0,3:G},{1,3:G},{2,3:G},{3,3:G})",voxels[i,0],voxels[i,1],voxels[i,2],voxels[i,3]);
			}
		}
	}
}
