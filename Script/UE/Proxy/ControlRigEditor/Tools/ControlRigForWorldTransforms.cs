using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigForWorldTransforms")]
	public partial class FControlRigForWorldTransforms : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigForWorldTransforms");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigForWorldTransforms() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigForWorldTransforms() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigForWorldTransforms A, FControlRigForWorldTransforms B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigForWorldTransforms A, FControlRigForWorldTransforms B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigForWorldTransforms;

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

		public TArray<FName> ControlNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlNames, __InBuffer);
				}
			}
		}

		private static uint __ControlRig = 0;

		private static uint __ControlNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}