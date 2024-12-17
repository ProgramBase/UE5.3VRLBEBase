using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigHierarchySettings")]
	public partial class FRigHierarchySettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigHierarchySettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigHierarchySettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigHierarchySettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigHierarchySettings A, FRigHierarchySettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigHierarchySettings A, FRigHierarchySettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigHierarchySettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ProceduralElementLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProceduralElementLimit, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProceduralElementLimit, __InBuffer);
				}
			}
		}

		private static uint __ProceduralElementLimit = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}