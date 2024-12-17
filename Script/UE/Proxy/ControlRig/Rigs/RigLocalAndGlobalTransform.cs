using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigLocalAndGlobalTransform")]
	public partial class FRigLocalAndGlobalTransform : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigLocalAndGlobalTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigLocalAndGlobalTransform() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigLocalAndGlobalTransform() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigLocalAndGlobalTransform A, FRigLocalAndGlobalTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigLocalAndGlobalTransform A, FRigLocalAndGlobalTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigLocalAndGlobalTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigComputedTransform Local
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Local, __ReturnBuffer);

					return *(FRigComputedTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Local, __InBuffer);
				}
			}
		}

		public FRigComputedTransform Global
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Global, __ReturnBuffer);

					return *(FRigComputedTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Global, __InBuffer);
				}
			}
		}

		private static uint __Local = 0;

		private static uint __Global = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}