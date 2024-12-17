using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetMaterialLibrary")]
	public partial class UKismetMaterialLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetMaterialLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, FLinearColor ParameterValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Collection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ParameterValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetVectorParameterValue, __InBuffer);
			}
		}

		public static void SetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float ParameterValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Collection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = ParameterValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetScalarParameterValue, __InBuffer);
			}
		}

		public static FLinearColor GetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Collection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetVectorParameterValue, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static float GetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Collection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetScalarParameterValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject, UMaterialInterface Parent, FName OptionalName = null, EMIDCreationFlags CreationFlags = EMIDCreationFlags.None)
		{
			unsafe
			{
				OptionalName ??= new FName("None");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OptionalName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)CreationFlags;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateDynamicMaterialInstance, __InBuffer, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		private static uint __SetVectorParameterValue = 0;

		private static uint __SetScalarParameterValue = 0;

		private static uint __GetVectorParameterValue = 0;

		private static uint __GetScalarParameterValue = 0;

		private static uint __CreateDynamicMaterialInstance = 0;
	}
}