using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.Selection")]
	public partial class USelection : UObject, IStaticClass
	{
		public UTypedElementSelectionSet ElementSelectionSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ElementSelectionSet, __ReturnBuffer);

					return *(UTypedElementSelectionSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ElementSelectionSet, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.Selection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ElementSelectionSet = 0;
	}
}