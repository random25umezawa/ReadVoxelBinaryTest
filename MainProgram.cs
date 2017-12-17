using System;
using BinaryTools;
using System.Drawing;

class MainProgram
{
	static void Main()
	{
		VoxData vd = new VoxData(new BinaryReader("res/kusa.vox"));
		Console.Write(vd.Type);
		Console.WriteLine(vd.Version);
		Console.WriteLine(vd.NumModels);

		int[,] sizes = vd.Sizes;
		Bitmap[] danmens = vd.Danmens;
		Bitmap[][] kaitentai = vd.Kaitentai;
		//foreach(Bitmap img in danmens)
		for(int modelIndex = 0; modelIndex < danmens.Length; modelIndex++)
		{
			Bitmap img = danmens[modelIndex];
			//img.MakeTransparent();
			img.Save("result/"+modelIndex+".png",System.Drawing.Imaging.ImageFormat.Png);
			img.Dispose();

			for(int angleCount = 0; angleCount < kaitentai[modelIndex].Length; angleCount++)
			{
				img = kaitentai[modelIndex][angleCount];
				img.Save("result/"+modelIndex+"_"+angleCount+".png",System.Drawing.Imaging.ImageFormat.Png);
				img.Dispose();
			}
		}
	}
}
