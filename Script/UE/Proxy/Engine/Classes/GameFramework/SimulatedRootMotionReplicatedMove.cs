using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SimulatedRootMotionReplicatedMove")]
	public partial class FSimulatedRootMotionReplicatedMove : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SimulatedRootMotionReplicatedMove");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSimulatedRootMotionReplicatedMove() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSimulatedRootMotionReplicatedMove() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSimulatedRootMotionReplicatedMove A, FSimulatedRootMotionReplicatedMove B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSimulatedRootMotionReplicatedMove A, FSimulatedRootMotionReplicatedMove B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSimulatedRootMotionReplicatedMove;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		public FRepRootMotionMontage RootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootMotion, __ReturnBuffer);

					return *(FRepRootMotionMontage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootMotion, __InBuffer);
				}
			}
		}

		private static uint __Time = 0;

		private static uint __RootMotion = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}