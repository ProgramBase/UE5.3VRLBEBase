using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.RigHierarchyImportSettings")]
	public partial class FRigHierarchyImportSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.RigHierarchyImportSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigHierarchyImportSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigHierarchyImportSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigHierarchyImportSettings A, FRigHierarchyImportSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigHierarchyImportSettings A, FRigHierarchyImportSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigHierarchyImportSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USkeletalMesh Mesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mesh, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mesh, __InBuffer);
				}
			}
		}

		private static uint __Mesh = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}