using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.AnimNode_ControlRig_ExternalSource")]
	public partial class FAnimNode_ControlRig_ExternalSource : FAnimNode_ControlRigBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.AnimNode_ControlRig_ExternalSource");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_ControlRig_ExternalSource()
		{
		}

		public static bool operator ==(FAnimNode_ControlRig_ExternalSource A, FAnimNode_ControlRig_ExternalSource B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_ControlRig_ExternalSource A, FAnimNode_ControlRig_ExternalSource B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_ControlRig_ExternalSource;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UControlRig> ControlRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlRig, __ReturnBuffer);

					return *(TWeakObjectPtr<UControlRig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlRig, __InBuffer);
				}
			}
		}

		private static uint __ControlRig = 0;

	}
}