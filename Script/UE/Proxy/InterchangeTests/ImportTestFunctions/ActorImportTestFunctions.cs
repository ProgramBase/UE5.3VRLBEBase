using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.ActorImportTestFunctions")]
	public partial class UActorImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.ActorImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckImportedActorCount(TArray<AActor> Actors, int ExpectedNumberOfImportedActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfImportedActors;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedActorCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckComponentPropertyValue(AActor Actor, FString ComponentName, FString PropertyName, bool bUseRegexToMatchValue, FString ExpectedValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ComponentName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bUseRegexToMatchValue;

				*(nint*)(__InBuffer + 25) = ExpectedValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckComponentPropertyValue, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckActorPropertyValue(AActor Actor, FString PropertyName, bool bUseRegexToMatchValue, FString ExpectedValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUseRegexToMatchValue;

				*(nint*)(__InBuffer + 17) = ExpectedValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckActorPropertyValue, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckActorClassCount(TArray<AActor> Actors, TSubclassOf<AActor> Class, int ExpectedNumberOfActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = ExpectedNumberOfActors;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckActorClassCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckActorClass(AActor Actor, TSubclassOf<AActor> ExpectedClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpectedClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckActorClass, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckImportedActorCount = 0;

		private static uint __CheckComponentPropertyValue = 0;

		private static uint __CheckActorPropertyValue = 0;

		private static uint __CheckActorClassCount = 0;

		private static uint __CheckActorClass = 0;
	}
}