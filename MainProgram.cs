using System;
using BinaryTools;

class MainProgram
{
	static void Main()
	{
		VoxData vd = new VoxData(new BinaryReader("res/kusa.vox"));
		Console.Write(vd.Type);
		Console.Write(vd.Version);
	}
}
