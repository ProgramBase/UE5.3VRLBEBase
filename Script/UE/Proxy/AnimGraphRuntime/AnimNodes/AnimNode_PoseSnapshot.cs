using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot")]
	public partial class FAnimNode_PoseSnapshot : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_PoseSnapshot()
		{
		}

		public static bool operator ==(FAnimNode_PoseSnapshot A, FAnimNode_PoseSnapshot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_PoseSnapshot A, FAnimNode_PoseSnapshot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_PoseSnapshot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName SnapshotName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotName, __InBuffer);
				}
			}
		}

		public FPoseSnapshot Snapshot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Snapshot, __ReturnBuffer);

					return *(FPoseSnapshot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Snapshot, __InBuffer);
				}
			}
		}

		public ESnapshotSourceMode Mode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __ReturnBuffer);

					return *(ESnapshotSourceMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __InBuffer);
				}
			}
		}

		private static uint __SnapshotName = 0;

		private static uint __Snapshot = 0;

		private static uint __Mode = 0;

	}
}