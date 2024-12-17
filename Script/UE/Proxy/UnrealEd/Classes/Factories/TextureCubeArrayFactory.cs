using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureCubeArrayFactory")]
	public partial class UTextureCubeArrayFactory : UFactory, IStaticClass
	{
		public TArray<UTextureCube> InitialTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialTextures, __ReturnBuffer);

					return *(TArray<UTextureCube>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialTextures, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureCubeArrayFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InitialTextures = 0;
	}
}