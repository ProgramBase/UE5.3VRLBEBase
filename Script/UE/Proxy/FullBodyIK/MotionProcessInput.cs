using Script.CoreUObject;
using Script.Library;

namespace Script.FullBodyIK
{
	[PathName("/Script/FullBodyIK.MotionProcessInput")]
	public partial class FMotionProcessInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FullBodyIK.MotionProcessInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMotionProcessInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMotionProcessInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMotionProcessInput A, FMotionProcessInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMotionProcessInput A, FMotionProcessInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMotionProcessInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bForceEffectorRotationTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceEffectorRotationTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceEffectorRotationTarget, __InBuffer);
				}
			}
		}

		public bool bOnlyApplyWhenReachedToTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOnlyApplyWhenReachedToTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOnlyApplyWhenReachedToTarget, __InBuffer);
				}
			}
		}

		private static uint __bForceEffectorRotationTarget = 0;

		private static uint __bOnlyApplyWhenReachedToTarget = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}