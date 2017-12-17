using System;
using BinaryTools;
using System.Drawing;

class MainProgram
{
	static void Main()
	{
		VoxData vd = new VoxData(new BinaryReader("res/3x3x3.vox"));
		Console.Write(vd.Type);
		Console.WriteLine(vd.Version);
		Console.WriteLine(vd.NumModels);
		
		int[,] sizes = vd.Sizes;
		int[][,,] danmens = vd.Danmens;
		for(int model_index = 0; model_index < vd.NumModels; model_index++)
		{
			Bitmap img = new Bitmap(sizes[model_index,0]*sizes[model_index,2],sizes[model_index,1]);
			img.MakeTransparent();
			for(int i = 0; i < sizes[model_index,0]*sizes[model_index,2]; i++)
			{
				for(int j = 0; j < sizes[model_index,1]; j++)
				{
					Color c = Color.FromArgb
					(
						danmens[model_index][i,j,3],
						danmens[model_index][i,j,0],
						danmens[model_index][i,j,1],
						danmens[model_index][i,j,2]
					);
					img.SetPixel(i,j,c);
				}
			}
			img.Save("result/"+model_index+".png",System.Drawing.Imaging.ImageFormat.Png);
			img.Dispose();
		}
	}
}
