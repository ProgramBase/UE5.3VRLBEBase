using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementHandleLibrary")]
	public partial class UTypedElementHandleLibrary : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementHandleLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void Release(ref FScriptTypedElementHandle ElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Release, __InBuffer, __OutBuffer);

				ElementHandle = *(FScriptTypedElementHandle*)(__OutBuffer);

			}
		}

		public static bool NotEqual(FScriptTypedElementHandle LHS, FScriptTypedElementHandle RHS)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LHS?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RHS?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsSet(FScriptTypedElementHandle ElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Equal(FScriptTypedElementHandle LHS, FScriptTypedElementHandle RHS)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LHS?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RHS?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Equal, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Release = 0;

		private static uint __NotEqual = 0;

		private static uint __IsSet = 0;

		private static uint __Equal = 0;
	}
}