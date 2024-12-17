using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.VariantManagerContent;

namespace Script.VariantManager
{
	[PathName("/Script/VariantManager.VariantManagerBlueprintLibrary")]
	public partial class UVariantManagerBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManager.VariantManagerBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetValueVector4(UPropertyValue Property, FVector4 InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueVector4, __InBuffer);
			}
		}

		public static void SetValueVector2D(UPropertyValue Property, FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueVector2D, __InBuffer);
			}
		}

		public static void SetValueVector(UPropertyValue Property, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueVector, __InBuffer);
			}
		}

		public static void SetValueString(UPropertyValue Property, FString InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueString, __InBuffer);
			}
		}

		public static void SetValueRotator(UPropertyValue Property, FRotator InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueRotator, __InBuffer);
			}
		}

		public static void SetValueQuat(UPropertyValue Property, FQuat InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueQuat, __InBuffer);
			}
		}

		public static void SetValueObject(UPropertyValue Property, UObject InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueObject, __InBuffer);
			}
		}

		public static void SetValueLinearColor(UPropertyValue Property, FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueLinearColor, __InBuffer);
			}
		}

		public static void SetValueIntPoint(UPropertyValue Property, FIntPoint InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueIntPoint, __InBuffer);
			}
		}

		public static void SetValueInt(UPropertyValue Property, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueInt, __InBuffer);
			}
		}

		public static void SetValueFloat(UPropertyValue Property, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueFloat, __InBuffer);
			}
		}

		public static void SetValueColor(UPropertyValue Property, FColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueColor, __InBuffer);
			}
		}

		public static void SetValueBool(UPropertyValue Property, bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetValueBool, __InBuffer);
			}
		}

		public static void SetDependency(UVariant Variant, int Index, ref FVariantDependency Dependency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = Dependency?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetDependency, __InBuffer, __OutBuffer);

				Dependency = *(FVariantDependency*)(__OutBuffer);

			}
		}

		public static void RemoveVariantSetByName(ULevelVariantSets LevelVariantSets, FString VariantSetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantSetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveVariantSetByName, __InBuffer);
			}
		}

		public static void RemoveVariantSet(ULevelVariantSets LevelVariantSets, UVariantSet VariantSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantSet?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveVariantSet, __InBuffer);
			}
		}

		public static void RemoveVariantByName(UVariantSet VariantSet, FString VariantName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VariantSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveVariantByName, __InBuffer);
			}
		}

		public static void RemoveVariant(UVariantSet VariantSet, UVariant Variant)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VariantSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveVariant, __InBuffer);
			}
		}

		public static void RemoveCapturedPropertyByName(UVariant Variant, AActor Actor, FString PropertyPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PropertyPath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveCapturedPropertyByName, __InBuffer);
			}
		}

		public static void RemoveCapturedProperty(UVariant Variant, AActor Actor, UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Property?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveCapturedProperty, __InBuffer);
			}
		}

		public static void RemoveActorBindingByName(UVariant Variant, FString ActorName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveActorBindingByName, __InBuffer);
			}
		}

		public static void RemoveActorBinding(UVariant Variant, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveActorBinding, __InBuffer);
			}
		}

		public static void Record(UPropertyValue PropVal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PropVal?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Record, __InBuffer);
			}
		}

		public static FVector4 GetValueVector4(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueVector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector2D GetValueVector2D(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector GetValueVector(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FString GetValueString(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FRotator GetValueRotator(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FQuat GetValueQuat(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static UObject GetValueObject(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static FLinearColor GetValueLinearColor(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FIntPoint GetValueIntPoint(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueIntPoint, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static int GetValueInt(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static float GetValueFloat(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FColor GetValueColor(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueColor, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static bool GetValueBool(UPropertyValue Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Property?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValueBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString GetPropertyTypeString(UPropertyValue PropVal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PropVal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPropertyTypeString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<UPropertyValue> GetCapturedProperties(UVariant Variant, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCapturedProperties, __InBuffer, __ReturnBuffer);

				return *(TArray<UPropertyValue>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetCapturableProperties(UObject ActorOrClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorOrClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCapturableProperties, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static void DeleteDependency(UVariant Variant, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteDependency, __InBuffer);
			}
		}

		public static ULevelVariantSets CreateLevelVariantSetsAsset(FString AssetName, FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateLevelVariantSetsAsset, __InBuffer, __ReturnBuffer);

				return *(ULevelVariantSets*)__ReturnBuffer;
			}
		}

		public static ALevelVariantSetsActor CreateLevelVariantSetsActor(ULevelVariantSets LevelVariantSetsAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelVariantSetsAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateLevelVariantSetsActor, __InBuffer, __ReturnBuffer);

				return *(ALevelVariantSetsActor*)__ReturnBuffer;
			}
		}

		public static UPropertyValue CaptureProperty(UVariant Variant, AActor Actor, FString PropertyPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PropertyPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CaptureProperty, __InBuffer, __ReturnBuffer);

				return *(UPropertyValue*)__ReturnBuffer;
			}
		}

		public static void Apply(UPropertyValue PropVal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PropVal?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Apply, __InBuffer);
			}
		}

		public static void AddVariantSet(ULevelVariantSets LevelVariantSets, UVariantSet VariantSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantSet?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddVariantSet, __InBuffer);
			}
		}

		public static void AddVariant(UVariantSet VariantSet, UVariant Variant)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VariantSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddVariant, __InBuffer);
			}
		}

		public static int AddDependency(UVariant Variant, ref FVariantDependency Dependency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dependency?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __AddDependency, __InBuffer, __OutBuffer, __ReturnBuffer);

				Dependency = *(FVariantDependency*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void AddActorBinding(UVariant Variant, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Variant?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddActorBinding, __InBuffer);
			}
		}

		private static uint __SetValueVector4 = 0;

		private static uint __SetValueVector2D = 0;

		private static uint __SetValueVector = 0;

		private static uint __SetValueString = 0;

		private static uint __SetValueRotator = 0;

		private static uint __SetValueQuat = 0;

		private static uint __SetValueObject = 0;

		private static uint __SetValueLinearColor = 0;

		private static uint __SetValueIntPoint = 0;

		private static uint __SetValueInt = 0;

		private static uint __SetValueFloat = 0;

		private static uint __SetValueColor = 0;

		private static uint __SetValueBool = 0;

		private static uint __SetDependency = 0;

		private static uint __RemoveVariantSetByName = 0;

		private static uint __RemoveVariantSet = 0;

		private static uint __RemoveVariantByName = 0;

		private static uint __RemoveVariant = 0;

		private static uint __RemoveCapturedPropertyByName = 0;

		private static uint __RemoveCapturedProperty = 0;

		private static uint __RemoveActorBindingByName = 0;

		private static uint __RemoveActorBinding = 0;

		private static uint __Record = 0;

		private static uint __GetValueVector4 = 0;

		private static uint __GetValueVector2D = 0;

		private static uint __GetValueVector = 0;

		private static uint __GetValueString = 0;

		private static uint __GetValueRotator = 0;

		private static uint __GetValueQuat = 0;

		private static uint __GetValueObject = 0;

		private static uint __GetValueLinearColor = 0;

		private static uint __GetValueIntPoint = 0;

		private static uint __GetValueInt = 0;

		private static uint __GetValueFloat = 0;

		private static uint __GetValueColor = 0;

		private static uint __GetValueBool = 0;

		private static uint __GetPropertyTypeString = 0;

		private static uint __GetCapturedProperties = 0;

		private static uint __GetCapturableProperties = 0;

		private static uint __DeleteDependency = 0;

		private static uint __CreateLevelVariantSetsAsset = 0;

		private static uint __CreateLevelVariantSetsActor = 0;

		private static uint __CaptureProperty = 0;

		private static uint __Apply = 0;

		private static uint __AddVariantSet = 0;

		private static uint __AddVariant = 0;

		private static uint __AddDependency = 0;

		private static uint __AddActorBinding = 0;
	}
}