using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimPhysPlanarLimit")]
	public partial class FAnimPhysPlanarLimit : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimPhysPlanarLimit");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimPhysPlanarLimit() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimPhysPlanarLimit() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimPhysPlanarLimit A, FAnimPhysPlanarLimit B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimPhysPlanarLimit A, FAnimPhysPlanarLimit B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimPhysPlanarLimit;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference DrivingBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DrivingBone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DrivingBone, __InBuffer);
				}
			}
		}

		public FTransform PlaneTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlaneTransform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlaneTransform, __InBuffer);
				}
			}
		}

		private static uint __DrivingBone = 0;

		private static uint __PlaneTransform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}