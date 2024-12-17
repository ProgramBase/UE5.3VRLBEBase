using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerDebugActor")]
	public partial class FGameplayDebuggerDebugActor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerDebugActor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerDebugActor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerDebugActor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerDebugActor A, FGameplayDebuggerDebugActor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerDebugActor A, FGameplayDebuggerDebugActor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerDebugActor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<AActor> Actor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Actor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Actor, __InBuffer);
				}
			}
		}

		public FName ActorName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorName, __InBuffer);
				}
			}
		}

		public short SyncCounter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SyncCounter, __ReturnBuffer);

					return *(short*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(short*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SyncCounter, __InBuffer);
				}
			}
		}

		private static uint __Actor = 0;

		private static uint __ActorName = 0;

		private static uint __SyncCounter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}