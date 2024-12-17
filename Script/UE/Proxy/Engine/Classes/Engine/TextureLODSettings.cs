using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureLODSettings")]
	public partial class UTextureLODSettings : UObject, IStaticClass
	{
		public TArray<FTextureLODGroup> TextureLODGroups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureLODGroups, __ReturnBuffer);

					return *(TArray<FTextureLODGroup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureLODGroups, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TextureLODSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TextureLODGroups = 0;
	}
}