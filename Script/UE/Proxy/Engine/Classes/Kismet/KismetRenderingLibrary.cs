using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetRenderingLibrary")]
	public partial class UKismetRenderingLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetRenderingLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetCastInsetShadowForAllAttachments(UPrimitiveComponent PrimitiveComponent, bool bCastInsetShadow, bool bLightAttachmentsAsGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = PrimitiveComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCastInsetShadow;

				*(bool*)(__InBuffer + 9) = bLightAttachmentsAsGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCastInsetShadowForAllAttachments, __InBuffer);
			}
		}

		public static void ResizeRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget, int Width = 256, int Height = 256)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResizeRenderTarget2D, __InBuffer);
			}
		}

		public static UTexture2D RenderTargetCreateStaticTexture2DEditorOnly(UTextureRenderTarget2D RenderTarget, FString Name = null, TextureCompressionSettings CompressionSettings = TextureCompressionSettings.TC_Default, TextureMipGenSettings MipSettings = TextureMipGenSettings.TMGS_FromTextureGroup)
		{
			unsafe
			{
				Name ??= new FString("Texture");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = RenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)CompressionSettings;

				*(byte*)(__InBuffer + 17) = (byte)MipSettings;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RenderTargetCreateStaticTexture2DEditorOnly, __InBuffer, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		public static void ReleaseRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReleaseRenderTarget2D, __InBuffer);
			}
		}

		public static void RefreshPathTracingOutput()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __RefreshPathTracingOutput);
			}
		}

		public static FColor ReadRenderTargetUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = U;

				*(float*)(__InBuffer + 20) = V;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetUV, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static TArray<FLinearColor> ReadRenderTargetRawUVArea(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FBox2D Area, bool bNormalize = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Area?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bNormalize;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetRawUVArea, __InBuffer, __ReturnBuffer);

				return *(TArray<FLinearColor>*)__ReturnBuffer;
			}
		}

		public static FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V, bool bNormalize = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = U;

				*(float*)(__InBuffer + 20) = V;

				*(bool*)(__InBuffer + 24) = bNormalize;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetRawUV, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static TArray<FLinearColor> ReadRenderTargetRawPixelArea(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int MinX, int MinY, int MaxX, int MaxY, bool bNormalize = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = MinX;

				*(int*)(__InBuffer + 20) = MinY;

				*(int*)(__InBuffer + 24) = MaxX;

				*(int*)(__InBuffer + 28) = MaxY;

				*(bool*)(__InBuffer + 32) = bNormalize;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetRawPixelArea, __InBuffer, __ReturnBuffer);

				return *(TArray<FLinearColor>*)__ReturnBuffer;
			}
		}

		public static FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y, bool bNormalize = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = X;

				*(int*)(__InBuffer + 20) = Y;

				*(bool*)(__InBuffer + 24) = bNormalize;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetRawPixel, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static bool ReadRenderTargetRaw(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, ref TArray<FLinearColor> OutLinearSamples, bool bNormalize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutLinearSamples?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bNormalize;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetRaw, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutLinearSamples = *(TArray<FLinearColor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FColor ReadRenderTargetPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = X;

				*(int*)(__InBuffer + 20) = Y;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTargetPixel, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static bool ReadRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, ref TArray<FColor> OutSamples, bool bNormalize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutSamples?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bNormalize;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ReadRenderTarget, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSamples = *(TArray<FColor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = Bone0;

				*(byte*)(__InBuffer + 4) = Weight0;

				*(int*)(__InBuffer + 5) = Bone1;

				*(byte*)(__InBuffer + 9) = Weight1;

				*(int*)(__InBuffer + 10) = Bone2;

				*(byte*)(__InBuffer + 14) = Weight2;

				*(int*)(__InBuffer + 15) = Bone3;

				*(byte*)(__InBuffer + 19) = Weight3;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeSkinWeightInfo, __InBuffer, __ReturnBuffer);

				return *(FSkelMeshSkinWeightInfo*)__ReturnBuffer;
			}
		}

		public static UTexture2D ImportFileAsTexture2D(UObject WorldContextObject, FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportFileAsTexture2D, __InBuffer, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		public static UTexture2D ImportBufferAsTexture2D(UObject WorldContextObject, TArray<byte> Buffer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Buffer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportBufferAsTexture2D, __InBuffer, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		public static void ExportTexture2D(UObject WorldContextObject, UTexture2D Texture, FString FilePath, FString FileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FilePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = FileName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ExportTexture2D, __InBuffer);
			}
		}

		public static void ExportRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FString FilePath, FString FileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FilePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = FileName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ExportRenderTarget, __InBuffer);
			}
		}

		public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject, FDrawToRenderTargetContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EndDrawCanvasToRenderTarget, __InBuffer);
			}
		}

		public static void EnablePathTracing(bool bEnablePathTracer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnablePathTracer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnablePathTracing, __InBuffer);
			}
		}

		public static void DrawMaterialToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawMaterialToRenderTarget, __InBuffer);
			}
		}

		public static UTextureRenderTargetVolume CreateRenderTargetVolume(UObject WorldContextObject, int Width = 16, int Height = 16, int Depth = 16, ETextureRenderTargetFormat Format = ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor ClearColor = null, bool bAutoGenerateMipMaps = false, bool bSupportUAVs = false)
		{
			unsafe
			{
				ClearColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[31];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				*(int*)(__InBuffer + 16) = Depth;

				*(byte*)(__InBuffer + 20) = (byte)Format;

				*(nint*)(__InBuffer + 21) = ClearColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 29) = bAutoGenerateMipMaps;

				*(bool*)(__InBuffer + 30) = bSupportUAVs;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateRenderTargetVolume, __InBuffer, __ReturnBuffer);

				return *(UTextureRenderTargetVolume*)__ReturnBuffer;
			}
		}

		public static UTextureRenderTarget2DArray CreateRenderTarget2DArray(UObject WorldContextObject, int Width = 256, int Height = 256, int Slices = 1, ETextureRenderTargetFormat Format = ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor ClearColor = null, bool bAutoGenerateMipMaps = false, bool bSupportUAVs = false)
		{
			unsafe
			{
				ClearColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[31];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				*(int*)(__InBuffer + 16) = Slices;

				*(byte*)(__InBuffer + 20) = (byte)Format;

				*(nint*)(__InBuffer + 21) = ClearColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 29) = bAutoGenerateMipMaps;

				*(bool*)(__InBuffer + 30) = bSupportUAVs;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateRenderTarget2DArray, __InBuffer, __ReturnBuffer);

				return *(UTextureRenderTarget2DArray*)__ReturnBuffer;
			}
		}

		public static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject, int Width = 256, int Height = 256, ETextureRenderTargetFormat Format = ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor ClearColor = null, bool bAutoGenerateMipMaps = false, bool bSupportUAVs = false)
		{
			unsafe
			{
				ClearColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[27];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				*(byte*)(__InBuffer + 16) = (byte)Format;

				*(nint*)(__InBuffer + 17) = ClearColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bAutoGenerateMipMaps;

				*(bool*)(__InBuffer + 26) = bSupportUAVs;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateRenderTarget2D, __InBuffer, __ReturnBuffer);

				return *(UTextureRenderTarget2D*)__ReturnBuffer;
			}
		}

		public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject, UTextureRenderTarget2D RenderTarget, UTexture2D Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ConvertRenderTargetToTexture2DEditorOnly, __InBuffer);
			}
		}

		public static void ClearRenderTarget2D(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FLinearColor ClearColor = null)
		{
			unsafe
			{
				ClearColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ClearColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearRenderTarget2D, __InBuffer);
			}
		}

		public static FMatrix CalculateProjectionMatrix(FMinimalViewInfo MinimalViewInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MinimalViewInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CalculateProjectionMatrix, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight, ref int Bone0, ref byte Weight0, ref int Bone1, ref byte Weight1, ref int Bone2, ref byte Weight2, ref int Bone3, ref byte Weight3)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InWeight?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Bone0;

				*(byte*)(__InBuffer + 12) = Weight0;

				*(int*)(__InBuffer + 13) = Bone1;

				*(byte*)(__InBuffer + 17) = Weight1;

				*(int*)(__InBuffer + 18) = Bone2;

				*(byte*)(__InBuffer + 22) = Weight2;

				*(int*)(__InBuffer + 23) = Bone3;

				*(byte*)(__InBuffer + 27) = Weight3;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakSkinWeightInfo, __InBuffer, __OutBuffer);

				Bone0 = *(int*)(__OutBuffer);

				Weight0 = *(byte*)(__OutBuffer + 4);

				Bone1 = *(int*)(__OutBuffer + 5);

				Weight1 = *(byte*)(__OutBuffer + 9);

				Bone2 = *(int*)(__OutBuffer + 10);

				Weight2 = *(byte*)(__OutBuffer + 14);

				Bone3 = *(int*)(__OutBuffer + 15);

				Weight3 = *(byte*)(__OutBuffer + 19);

			}
		}

		public static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, ref UCanvas Canvas, ref FVector2D Size, ref FDrawToRenderTargetContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Canvas?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Size?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BeginDrawCanvasToRenderTarget, __InBuffer, __OutBuffer);

				Canvas = *(UCanvas*)(__OutBuffer);

				Size = *(FVector2D*)(__OutBuffer + 8);

				Context = *(FDrawToRenderTargetContext*)(__OutBuffer + 16);

			}
		}

		private static uint __SetCastInsetShadowForAllAttachments = 0;

		private static uint __ResizeRenderTarget2D = 0;

		private static uint __RenderTargetCreateStaticTexture2DEditorOnly = 0;

		private static uint __ReleaseRenderTarget2D = 0;

		private static uint __RefreshPathTracingOutput = 0;

		private static uint __ReadRenderTargetUV = 0;

		private static uint __ReadRenderTargetRawUVArea = 0;

		private static uint __ReadRenderTargetRawUV = 0;

		private static uint __ReadRenderTargetRawPixelArea = 0;

		private static uint __ReadRenderTargetRawPixel = 0;

		private static uint __ReadRenderTargetRaw = 0;

		private static uint __ReadRenderTargetPixel = 0;

		private static uint __ReadRenderTarget = 0;

		private static uint __MakeSkinWeightInfo = 0;

		private static uint __ImportFileAsTexture2D = 0;

		private static uint __ImportBufferAsTexture2D = 0;

		private static uint __ExportTexture2D = 0;

		private static uint __ExportRenderTarget = 0;

		private static uint __EndDrawCanvasToRenderTarget = 0;

		private static uint __EnablePathTracing = 0;

		private static uint __DrawMaterialToRenderTarget = 0;

		private static uint __CreateRenderTargetVolume = 0;

		private static uint __CreateRenderTarget2DArray = 0;

		private static uint __CreateRenderTarget2D = 0;

		private static uint __ConvertRenderTargetToTexture2DEditorOnly = 0;

		private static uint __ClearRenderTarget2D = 0;

		private static uint __CalculateProjectionMatrix = 0;

		private static uint __BreakSkinWeightInfo = 0;

		private static uint __BeginDrawCanvasToRenderTarget = 0;
	}
}