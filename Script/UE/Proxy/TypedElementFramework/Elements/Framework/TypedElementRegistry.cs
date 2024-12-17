using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementRegistry")]
	public partial class UTypedElementRegistry : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UTypedElementRegistry GetInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetInstance, __ReturnBuffer);

				return *(UTypedElementRegistry*)__ReturnBuffer;
			}
		}

		public virtual UObject GetElementInterface(FScriptTypedElementHandle InElementHandle, TSubclassOf<UInterface> InBaseInterfaceType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBaseInterfaceType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetElementInterface, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		private static uint __GetInstance = 0;

		private static uint __GetElementInterface = 0;
	}
}