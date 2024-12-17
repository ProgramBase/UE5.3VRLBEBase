using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.HandKeypointConversion")]
	public partial class UHandKeypointConversion : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HeadMountedDisplay.HandKeypointConversion");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static int Conv_HandKeypointToInt32(EHandKeypoint input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)input;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_HandKeypointToInt32, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __Conv_HandKeypointToInt32 = 0;
	}
}