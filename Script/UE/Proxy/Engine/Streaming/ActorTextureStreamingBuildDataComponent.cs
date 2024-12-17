using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorTextureStreamingBuildDataComponent")]
	public partial class UActorTextureStreamingBuildDataComponent : UActorComponent, IStaticClass
	{
		public TArray<FStreamableTexture> StreamableTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamableTextures, __ReturnBuffer);

					return *(TArray<FStreamableTexture>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamableTextures, __InBuffer);
				}
			}
		}

		public uint PackedTextureStreamingQualityLevelFeatureLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PackedTextureStreamingQualityLevelFeatureLevel, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PackedTextureStreamingQualityLevelFeatureLevel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorTextureStreamingBuildDataComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StreamableTextures = 0;

		private static uint __PackedTextureStreamingQualityLevelFeatureLevel = 0;
	}
}