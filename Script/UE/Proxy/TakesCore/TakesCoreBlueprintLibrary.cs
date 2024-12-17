using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.TakesCore.TakesCoreBlueprintLibrary;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.TakesCoreBlueprintLibrary")]
	public partial class UTakesCoreBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakesCore.TakesCoreBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetOnTakeRecorderTakeNumberChanged(FOnTakeRecorderTakeNumberChanged OnTakeRecorderTakeNumberChanged)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderTakeNumberChanged?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderTakeNumberChanged, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged OnTakeRecorderSlateChanged)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderSlateChanged?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderSlateChanged, __InBuffer);
			}
		}

		/// <param name="Slate">
		/// The slate to filter by
		/// </param>
		/// <param name="TakeNumber">
		/// The take number to filter by. <=0 denotes all takes
		/// </param>
		public static TArray<FAssetData> FindTakes(FString Slate, int TakeNumber = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Slate?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = TakeNumber;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindTakes, __InBuffer, __ReturnBuffer);

				return *(TArray<FAssetData>*)__ReturnBuffer;
			}
		}

		public static int ComputeNextTakeNumber(FString Slate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Slate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ComputeNextTakeNumber, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetOnTakeRecorderTakeNumberChanged = 0;

		private static uint __SetOnTakeRecorderSlateChanged = 0;

		private static uint __FindTakes = 0;

		private static uint __ComputeNextTakeNumber = 0;
	}
}