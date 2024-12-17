using Script.CoreUObject;
using Script.Library;

namespace Script.PinnedCommandList
{
	[PathName("/Script/PinnedCommandList.PinnedCommandListSettings")]
	public partial class UPinnedCommandListSettings : UObject, IStaticClass
	{
		public TArray<FPinnedCommandListContext> Contexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Contexts, __ReturnBuffer);

					return *(TArray<FPinnedCommandListContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Contexts, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PinnedCommandList.PinnedCommandListSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Contexts = 0;
	}
}