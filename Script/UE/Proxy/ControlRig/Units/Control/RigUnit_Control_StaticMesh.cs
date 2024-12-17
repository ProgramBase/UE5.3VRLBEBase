using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_Control_StaticMesh")]
	public partial class FRigUnit_Control_StaticMesh : FRigUnit_Control, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_Control_StaticMesh");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_Control_StaticMesh()
		{
		}

		public static bool operator ==(FRigUnit_Control_StaticMesh A, FRigUnit_Control_StaticMesh B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_Control_StaticMesh A, FRigUnit_Control_StaticMesh B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_Control_StaticMesh;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform MeshTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshTransform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshTransform, __InBuffer);
				}
			}
		}

		private static uint __MeshTransform = 0;

	}
}