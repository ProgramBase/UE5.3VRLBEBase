using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyQueue")]
	public partial class FAnimNotifyQueue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNotifyQueue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNotifyQueue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimNotifyQueue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimNotifyQueue A, FAnimNotifyQueue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNotifyQueue A, FAnimNotifyQueue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNotifyQueue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAnimNotifyEventReference> AnimNotifies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimNotifies, __ReturnBuffer);

					return *(TArray<FAnimNotifyEventReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimNotifies, __InBuffer);
				}
			}
		}

		public TMap<FName, FAnimNotifyArray> UnfilteredMontageAnimNotifies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UnfilteredMontageAnimNotifies, __ReturnBuffer);

					return *(TMap<FName, FAnimNotifyArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UnfilteredMontageAnimNotifies, __InBuffer);
				}
			}
		}

		private static uint __AnimNotifies = 0;

		private static uint __UnfilteredMontageAnimNotifies = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}