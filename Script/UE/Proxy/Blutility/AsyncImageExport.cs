using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AsyncImageExport")]
	public partial class UAsyncImageExport : UBlueprintAsyncActionBase, IStaticClass
	{
		public FOnExportImageAsyncComplete Complete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __ReturnBuffer);

					return *(FOnExportImageAsyncComplete*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __InBuffer);
				}
			}
		}

		public UTexture TextureToExport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureToExport, __ReturnBuffer);

					return *(UTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureToExport, __InBuffer);
				}
			}
		}

		public int Quality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Quality, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Quality, __InBuffer);
				}
			}
		}

		public FString TargetFile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetFile, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetFile, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AsyncImageExport");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncImageExport ExportImageAsync(UTexture Texture, FString OutputFile, int Quality = 100)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutputFile?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Quality;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ExportImageAsync, __InBuffer, __ReturnBuffer);

				return *(UAsyncImageExport*)__ReturnBuffer;
			}
		}

		private static uint __Complete = 0;

		private static uint __TextureToExport = 0;

		private static uint __Quality = 0;

		private static uint __TargetFile = 0;

		private static uint __ExportImageAsync = 0;
	}
}