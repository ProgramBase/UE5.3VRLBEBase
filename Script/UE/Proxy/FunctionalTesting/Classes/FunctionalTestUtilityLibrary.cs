using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.FunctionalTestUtilityLibrary")]
	public partial class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.FunctionalTestUtilityLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UTraceQueryTestResults TraceChannelTestUtil(UObject WorldContextObject, FTraceChannelTestBatchOptions BatchOptions, FVector Start, FVector End, float SphereCapsuleRadius, float CapsuleHalfHeight, FVector BoxHalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, TArray<EObjectTypeQuery> ObjectTypes, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, bool bIgnoreSelf, EDrawDebugTrace DrawDebugType, FLinearColor TraceColor = null, FLinearColor TraceHitColor = null, float DrawTime = 5.000000f)
		{
			unsafe
			{
				TraceColor ??= new FLinearColor(1.000000f, 0.000000f, 0.000000f, 1.000000f);

				TraceHitColor ??= new FLinearColor(0.000000f, 1.000000f, 0.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[104];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BatchOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = SphereCapsuleRadius;

				*(float*)(__InBuffer + 36) = CapsuleHalfHeight;

				*(nint*)(__InBuffer + 40) = BoxHalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 56) = (byte)TraceChannel;

				*(nint*)(__InBuffer + 57) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 65) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 73) = bTraceComplex;

				*(nint*)(__InBuffer + 74) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 82) = bIgnoreSelf;

				*(byte*)(__InBuffer + 83) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 84) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 92) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 100) = DrawTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TraceChannelTestUtil, __InBuffer, __ReturnBuffer);

				return *(UTraceQueryTestResults*)__ReturnBuffer;
			}
		}

		private static uint __TraceChannelTestUtil = 0;
	}
}