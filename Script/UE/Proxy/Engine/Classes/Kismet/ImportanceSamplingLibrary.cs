using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ImportanceSamplingLibrary")]
	public partial class UImportanceSamplingLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ImportanceSamplingLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Index">
		/// - Which sequential point
		/// </param>
		/// <param name="Dimension">
		/// - Which Sobol dimension (0 to 15)
		/// </param>
		/// <param name="Seed">
		/// - Random seed (in the range 0-1) to randomize across multiple sequences
		/// </param>
		/// <returns>
		/// Sobol-distributed random number between 0 and 1
		/// </returns>
		public static float RandomSobolFloat(int Index, int Dimension, float Seed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(int*)(__InBuffer + 4) = Dimension;

				*(float*)(__InBuffer + 8) = Seed;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomSobolFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// - Which sequential point in the cell (starting at 0)
		/// </param>
		/// <param name="NumCells">
		/// - Size of cell grid, 1 to 1024. Rounded up to the next power of two
		/// </param>
		/// <param name="Cell">
		/// - Give a point from this integer grid cell
		/// </param>
		/// <param name="Seed">
		/// - Random 3D seed (components in the range 0-1) to randomize across multiple sequences
		/// </param>
		/// <returns>
		/// Sobol-distributed random 3D vector in the given grid cell
		/// </returns>
		public static FVector RandomSobolCell3D(int Index, int NumCells = 1, FVector Cell = null, FVector Seed = null)
		{
			unsafe
			{
				Cell ??= new FVector(0.000000, 0.000000, 0.000000);

				Seed ??= new FVector(0.000000, 0.000000, 0.000000);

				var __InBuffer = stackalloc byte[24];

				*(int*)(__InBuffer) = Index;

				*(int*)(__InBuffer + 4) = NumCells;

				*(nint*)(__InBuffer + 8) = Cell?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Seed?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomSobolCell3D, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// - Which sequential point in the cell (starting at 0)
		/// </param>
		/// <param name="NumCells">
		/// - Size of cell grid, 1 to 32768. Rounded up to the next power of two
		/// </param>
		/// <param name="Cell">
		/// - Give a point from this integer grid cell
		/// </param>
		/// <param name="Seed">
		/// - Random 2D seed (components in the range 0-1) to randomize across multiple sequences
		/// </param>
		/// <returns>
		/// Sobol-distributed random 2D position in the given grid cell
		/// </returns>
		public static FVector2D RandomSobolCell2D(int Index, int NumCells = 1, FVector2D Cell = null, FVector2D Seed = null)
		{
			unsafe
			{
				Cell ??= new FVector2D(0.000000, 0.000000);

				Seed ??= new FVector2D(0.000000, 0.000000);

				var __InBuffer = stackalloc byte[24];

				*(int*)(__InBuffer) = Index;

				*(int*)(__InBuffer + 4) = NumCells;

				*(nint*)(__InBuffer + 8) = Cell?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Seed?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomSobolCell2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// - Which sequential point
		/// </param>
		/// <param name="Dimension">
		/// - Which Sobol dimension (0 to 15)
		/// </param>
		/// <param name="PreviousValue">
		/// - The Sobol value for Index-1
		/// </param>
		/// <returns>
		/// Sobol-distributed random number between 0 and 1
		/// </returns>
		public static float NextSobolFloat(int Index, int Dimension, float PreviousValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(int*)(__InBuffer + 4) = Dimension;

				*(float*)(__InBuffer + 8) = PreviousValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NextSobolFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// - Which sequential point
		/// </param>
		/// <param name="NumCells">
		/// - Size of cell grid, 1 to 1024. Rounded up to the next power of two
		/// </param>
		/// <param name="PreviousValue">
		/// - The Sobol value for Index-1
		/// </param>
		/// <returns>
		/// Sobol-distributed random 3D position in the same grid cell
		/// </returns>
		public static FVector NextSobolCell3D(int Index, int NumCells = 1, FVector PreviousValue = null)
		{
			unsafe
			{
				PreviousValue ??= new FVector(0.000000, 0.000000, 0.000000);

				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = Index;

				*(int*)(__InBuffer + 4) = NumCells;

				*(nint*)(__InBuffer + 8) = PreviousValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NextSobolCell3D, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// - Which sequential point
		/// </param>
		/// <param name="NumCells">
		/// - Size of cell grid, 1 to 32768. Rounded up to the next power of two
		/// </param>
		/// <param name="PreviousValue">
		/// - The Sobol value for Index-1
		/// </param>
		/// <returns>
		/// Sobol-distributed random 2D position in the same grid cell
		/// </returns>
		public static FVector2D NextSobolCell2D(int Index, int NumCells = 1, FVector2D PreviousValue = null)
		{
			unsafe
			{
				PreviousValue ??= new FVector2D(0.000000, 0.000000);

				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = Index;

				*(int*)(__InBuffer + 4) = NumCells;

				*(nint*)(__InBuffer + 8) = PreviousValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NextSobolCell2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="Texture">
		/// - Texture object to use. Must be RGBA8 format.
		/// </param>
		/// <param name="WeightingFunc">
		/// - How to turn the texture data into probability weights
		/// </param>
		/// <returns>
		/// new ImportanceTexture object for use with ImportanceSample
		/// </returns>
		public static FImportanceTexture MakeImportanceTexture(UTexture2D Texture, EImportanceWeight WeightingFunc)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)WeightingFunc;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeImportanceTexture, __InBuffer, __ReturnBuffer);

				return *(FImportanceTexture*)__ReturnBuffer;
			}
		}

		/// <param name="Rand">
		/// - Random 2D point with components evenly distributed between 0 and 1
		/// </param>
		/// <param name="Samples">
		/// - Total number of samples that will be used
		/// </param>
		/// <param name="Intensity">
		/// - Total intensity for light
		/// </param>
		/// <outparam>
		/// SamplePosition - Importance sampled 2D output texture coordinate (0-1)
		/// </outparam>
		/// <outparam>
		/// SampleColor - Representative color near Position from MIP level for SampleSize
		/// </outparam>
		/// <outparam>
		/// SampleIntensity - Intensity of individual points, scaled by probability and number of samples
		/// </outparam>
		/// <outparam>
		/// SampleSize - Local density of points near Position (scaled for 1x1 texture space)
		/// </outparam>
		public static void ImportanceSample(FImportanceTexture Texture, FVector2D Rand, int Samples, float Intensity, ref FVector2D SamplePosition, ref FLinearColor SampleColor, ref float SampleIntensity, ref float SampleSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Rand?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Samples;

				*(float*)(__InBuffer + 20) = Intensity;

				*(nint*)(__InBuffer + 24) = SamplePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = SampleColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = SampleIntensity;

				*(float*)(__InBuffer + 44) = SampleSize;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ImportanceSample, __InBuffer, __OutBuffer);

				SamplePosition = *(FVector2D*)(__OutBuffer);

				SampleColor = *(FLinearColor*)(__OutBuffer + 8);

				SampleIntensity = *(float*)(__OutBuffer + 16);

				SampleSize = *(float*)(__OutBuffer + 20);

			}
		}

		/// <param name="ImportanceTexture">
		/// - The source ImportanceTexture object
		/// </param>
		/// <outparam>
		/// Texture - Texture object for this ImportanceTexture.
		/// </outparam>
		/// <param name="WeightingFunc">
		/// - How to turn the texture data into probability weights
		/// </param>
		/// <returns>
		/// new ImportanceTexture object for use with ImportanceSample
		/// </returns>
		public static void BreakImportanceTexture(FImportanceTexture ImportanceTexture, ref UTexture2D Texture, ref EImportanceWeight WeightingFunc)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ImportanceTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)WeightingFunc;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakImportanceTexture, __InBuffer, __OutBuffer);

				Texture = *(UTexture2D*)(__OutBuffer);

				WeightingFunc = *(EImportanceWeight*)(__OutBuffer + 8);

			}
		}

		private static uint __RandomSobolFloat = 0;

		private static uint __RandomSobolCell3D = 0;

		private static uint __RandomSobolCell2D = 0;

		private static uint __NextSobolFloat = 0;

		private static uint __NextSobolCell3D = 0;

		private static uint __NextSobolCell2D = 0;

		private static uint __MakeImportanceTexture = 0;

		private static uint __ImportanceSample = 0;

		private static uint __BreakImportanceTexture = 0;
	}
}