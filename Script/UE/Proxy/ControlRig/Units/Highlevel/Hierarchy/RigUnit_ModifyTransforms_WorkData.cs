using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ModifyTransforms_WorkData")]
	public partial class FRigUnit_ModifyTransforms_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ModifyTransforms_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ModifyTransforms_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_ModifyTransforms_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_ModifyTransforms_WorkData A, FRigUnit_ModifyTransforms_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ModifyTransforms_WorkData A, FRigUnit_ModifyTransforms_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ModifyTransforms_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedItems, __ReturnBuffer);

					return *(TArray<FCachedRigElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedItems, __InBuffer);
				}
			}
		}

		private static uint __CachedItems = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}