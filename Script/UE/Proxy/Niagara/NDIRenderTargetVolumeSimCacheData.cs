using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDIRenderTargetVolumeSimCacheData")]
	public partial class UNDIRenderTargetVolumeSimCacheData : UObject, IStaticClass
	{
		public FName CompressionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionType, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionType, __InBuffer);
				}
			}
		}

		public TArray<FNDIRenderTargetVolumeSimCacheFrame> Frames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Frames, __ReturnBuffer);

					return *(TArray<FNDIRenderTargetVolumeSimCacheFrame>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Frames, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NDIRenderTargetVolumeSimCacheData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CompressionType = 0;

		private static uint __Frames = 0;
	}
}