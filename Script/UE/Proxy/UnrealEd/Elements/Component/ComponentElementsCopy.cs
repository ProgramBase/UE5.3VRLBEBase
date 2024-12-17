using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ComponentElementsCopy")]
	public partial class UComponentElementsCopy : UObject, IStaticClass
	{
		public TArray<UActorComponent> ComponentsToCopy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentsToCopy, __ReturnBuffer);

					return *(TArray<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentsToCopy, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ComponentElementsCopy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ComponentsToCopy = 0;
	}
}