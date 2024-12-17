using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.AnimationAttributeBlueprintLibrary")]
	public partial class UAnimationAttributeBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintLibrary.AnimationAttributeBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool SetAttributeKeys(TScriptInterface<IAnimationDataController> AnimationDataController, FAnimationAttributeIdentifier AttributeIdentifier, TArray<float> Times, TArray<int> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationDataController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetAttributeKeys, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetAttributeKey(TScriptInterface<IAnimationDataController> AnimationDataController, FAnimationAttributeIdentifier AttributeIdentifier, float Time, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationDataController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(int*)(__InBuffer + 20) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetAttributeKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetAttributeKeys(TScriptInterface<IAnimationDataModel> AnimationDataModel, FAnimationAttributeIdentifier AttributeIdentifier, ref TArray<float> OutTimes, ref TArray<int> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationDataModel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutTimes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAttributeKeys, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTimes = *(TArray<float>*)(__OutBuffer);

				Values = *(TArray<int>*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetAttributeKey(TScriptInterface<IAnimationDataModel> AnimationDataModel, FAnimationAttributeIdentifier AttributeIdentifier, float Time, ref int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationDataModel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(int*)(__InBuffer + 20) = Value;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAttributeKey, __InBuffer, __OutBuffer, __ReturnBuffer);

				Value = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetAttributeKeys = 0;

		private static uint __SetAttributeKey = 0;

		private static uint __GetAttributeKeys = 0;

		private static uint __GetAttributeKey = 0;
	}
}