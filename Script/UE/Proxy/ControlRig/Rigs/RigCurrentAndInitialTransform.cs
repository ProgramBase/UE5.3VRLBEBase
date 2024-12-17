using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigCurrentAndInitialTransform")]
	public partial class FRigCurrentAndInitialTransform : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigCurrentAndInitialTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigCurrentAndInitialTransform() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigCurrentAndInitialTransform() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigCurrentAndInitialTransform A, FRigCurrentAndInitialTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigCurrentAndInitialTransform A, FRigCurrentAndInitialTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigCurrentAndInitialTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigLocalAndGlobalTransform Current
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Current, __ReturnBuffer);

					return *(FRigLocalAndGlobalTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Current, __InBuffer);
				}
			}
		}

		public FRigLocalAndGlobalTransform Initial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Initial, __ReturnBuffer);

					return *(FRigLocalAndGlobalTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Initial, __InBuffer);
				}
			}
		}

		private static uint __Current = 0;

		private static uint __Initial = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}