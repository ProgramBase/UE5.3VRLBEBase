using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigSequenceObjectReference")]
	public partial class FControlRigSequenceObjectReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigSequenceObjectReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSequenceObjectReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSequenceObjectReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSequenceObjectReference A, FControlRigSequenceObjectReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSequenceObjectReference A, FControlRigSequenceObjectReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSequenceObjectReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UControlRig> ControlRigClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlRigClass, __ReturnBuffer);

					return *(TSubclassOf<UControlRig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlRigClass, __InBuffer);
				}
			}
		}

		private static uint __ControlRigClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}