using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigSequenceObjectReferences")]
	public partial class FControlRigSequenceObjectReferences : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigSequenceObjectReferences");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSequenceObjectReferences() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSequenceObjectReferences() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSequenceObjectReferences A, FControlRigSequenceObjectReferences B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSequenceObjectReferences A, FControlRigSequenceObjectReferences B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSequenceObjectReferences;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FControlRigSequenceObjectReference> Array
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Array, __ReturnBuffer);

					return *(TArray<FControlRigSequenceObjectReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Array, __InBuffer);
				}
			}
		}

		private static uint __Array = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}