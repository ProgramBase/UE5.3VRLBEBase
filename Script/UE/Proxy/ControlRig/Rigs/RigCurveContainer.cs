using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigCurveContainer")]
	public partial class FRigCurveContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigCurveContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigCurveContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigCurveContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigCurveContainer A, FRigCurveContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigCurveContainer A, FRigCurveContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigCurveContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigCurve> Curves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Curves, __ReturnBuffer);

					return *(TArray<FRigCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Curves, __InBuffer);
				}
			}
		}

		private static uint __Curves = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}