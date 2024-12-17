using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestObjectLibrary")]
	public partial class UPyTestObjectLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestObjectLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool IsBoolSet(UPyTestObject InObj)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InObj?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsBoolSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetOtherConstantValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetOtherConstantValue, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __IsBoolSet = 0;

		private static uint __GetOtherConstantValue = 0;
	}
}