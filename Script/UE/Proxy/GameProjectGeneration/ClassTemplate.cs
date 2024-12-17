using Script.CoreUObject;
using Script.Library;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.ClassTemplate")]
	public partial class UClassTemplate : UObject, IStaticClass
	{
		public TSubclassOf<UObject> GeneratedBaseClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratedBaseClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratedBaseClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameProjectGeneration.ClassTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GeneratedBaseClass = 0;
	}
}