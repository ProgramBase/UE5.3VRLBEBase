using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_AnimRichCurve")]
	public partial class FRigVMFunction_AnimRichCurve : FRigVMFunction_AnimBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_AnimRichCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_AnimRichCurve()
		{
		}

		public static bool operator ==(FRigVMFunction_AnimRichCurve A, FRigVMFunction_AnimRichCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_AnimRichCurve A, FRigVMFunction_AnimRichCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_AnimRichCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRuntimeFloatCurve Curve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __ReturnBuffer);

					return *(FRuntimeFloatCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __InBuffer);
				}
			}
		}

		private static uint __Curve = 0;

	}
}