using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.PerBlueprintSettings")]
	public partial class FPerBlueprintSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.PerBlueprintSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerBlueprintSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerBlueprintSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerBlueprintSettings A, FPerBlueprintSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerBlueprintSettings A, FPerBlueprintSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerBlueprintSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBlueprintBreakpoint> Breakpoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Breakpoints, __ReturnBuffer);

					return *(TArray<FBlueprintBreakpoint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Breakpoints, __InBuffer);
				}
			}
		}

		public TArray<FBlueprintWatchedPin> WatchedPins
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WatchedPins, __ReturnBuffer);

					return *(TArray<FBlueprintWatchedPin>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WatchedPins, __InBuffer);
				}
			}
		}

		private static uint __Breakpoints = 0;

		private static uint __WatchedPins = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}