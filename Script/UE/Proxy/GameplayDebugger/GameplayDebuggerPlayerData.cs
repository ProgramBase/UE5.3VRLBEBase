using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerPlayerData")]
	public partial class FGameplayDebuggerPlayerData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerPlayerData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerPlayerData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerPlayerData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerPlayerData A, FGameplayDebuggerPlayerData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerPlayerData A, FGameplayDebuggerPlayerData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerPlayerData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UGameplayDebuggerLocalController Controller
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Controller, __ReturnBuffer);

					return *(UGameplayDebuggerLocalController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Controller, __InBuffer);
				}
			}
		}

		public UInputComponent InputComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputComponent, __ReturnBuffer);

					return *(UInputComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputComponent, __InBuffer);
				}
			}
		}

		public AGameplayDebuggerCategoryReplicator Replicator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Replicator, __ReturnBuffer);

					return *(AGameplayDebuggerCategoryReplicator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Replicator, __InBuffer);
				}
			}
		}

		private static uint __Controller = 0;

		private static uint __InputComponent = 0;

		private static uint __Replicator = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}