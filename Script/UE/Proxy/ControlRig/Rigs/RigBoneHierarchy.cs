using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigBoneHierarchy")]
	public partial class FRigBoneHierarchy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigBoneHierarchy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigBoneHierarchy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigBoneHierarchy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigBoneHierarchy A, FRigBoneHierarchy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigBoneHierarchy A, FRigBoneHierarchy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigBoneHierarchy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigBone> Bones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bones, __ReturnBuffer);

					return *(TArray<FRigBone>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bones, __InBuffer);
				}
			}
		}

		private static uint __Bones = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}