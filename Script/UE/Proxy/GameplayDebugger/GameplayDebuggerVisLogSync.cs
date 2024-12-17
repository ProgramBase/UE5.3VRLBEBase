using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerVisLogSync")]
	public partial class FGameplayDebuggerVisLogSync : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerVisLogSync");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerVisLogSync() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerVisLogSync() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerVisLogSync A, FGameplayDebuggerVisLogSync B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerVisLogSync A, FGameplayDebuggerVisLogSync B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerVisLogSync;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DeviceIDs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceIDs, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceIDs, __InBuffer);
				}
			}
		}

		private static uint __DeviceIDs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}