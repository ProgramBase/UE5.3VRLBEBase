using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HealthSnapshotBlueprintLibrary")]
	public partial class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HealthSnapshotBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void StopPerformanceSnapshots()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __StopPerformanceSnapshots);
			}
		}

		public static void StartPerformanceSnapshots()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __StartPerformanceSnapshots);
			}
		}

		/// <param name="SnapshotTitle">
		/// The name to be given to the new HealthSnapshot.
		/// </param>
		public static void LogPerformanceSnapshot(FString SnapshotTitle, bool bResetStats = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SnapshotTitle?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bResetStats;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LogPerformanceSnapshot, __InBuffer);
			}
		}

		private static uint __StopPerformanceSnapshots = 0;

		private static uint __StartPerformanceSnapshots = 0;

		private static uint __LogPerformanceSnapshot = 0;
	}
}