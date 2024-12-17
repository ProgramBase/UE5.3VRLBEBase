using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BuiltInAttributesExtensions")]
	public partial class UBuiltInAttributesExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BuiltInAttributesExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool AddTransformAttribute(UAnimSequenceBase AnimSequenceBase, FName AttributeName, FName BoneName, TArray<float> Keys, TArray<FTransform> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = AnimSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Keys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddTransformAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __AddTransformAttribute = 0;
	}
}