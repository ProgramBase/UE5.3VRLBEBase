using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigSequenceObjectReferenceMap")]
	public partial class FControlRigSequenceObjectReferenceMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigSequenceObjectReferenceMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSequenceObjectReferenceMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSequenceObjectReferenceMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSequenceObjectReferenceMap A, FControlRigSequenceObjectReferenceMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSequenceObjectReferenceMap A, FControlRigSequenceObjectReferenceMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSequenceObjectReferenceMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FGuid> BindingIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingIds, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingIds, __InBuffer);
				}
			}
		}

		public TArray<FControlRigSequenceObjectReferences> References
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __References, __ReturnBuffer);

					return *(TArray<FControlRigSequenceObjectReferences>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __References, __InBuffer);
				}
			}
		}

		private static uint __BindingIds = 0;

		private static uint __References = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}