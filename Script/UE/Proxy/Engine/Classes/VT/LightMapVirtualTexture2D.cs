using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightMapVirtualTexture2D")]
	public partial class ULightMapVirtualTexture2D : UTexture2D, IStaticClass
	{
		public TArray<sbyte> TypeToLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TypeToLayer, __ReturnBuffer);

					return *(TArray<sbyte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TypeToLayer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightMapVirtualTexture2D");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TypeToLayer = 0;
	}
}