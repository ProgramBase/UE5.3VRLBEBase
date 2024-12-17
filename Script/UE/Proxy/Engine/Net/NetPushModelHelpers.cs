using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetPushModelHelpers")]
	public partial class UNetPushModelHelpers : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NetPushModelHelpers");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void MarkPropertyDirtyFromRepIndex(UObject Object, int RepIndex, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = RepIndex;

				*(nint*)(__InBuffer + 12) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __MarkPropertyDirtyFromRepIndex, __InBuffer);
			}
		}

		public static void MarkPropertyDirty(UObject Object, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __MarkPropertyDirty, __InBuffer);
			}
		}

		private static uint __MarkPropertyDirtyFromRepIndex = 0;

		private static uint __MarkPropertyDirty = 0;
	}
}