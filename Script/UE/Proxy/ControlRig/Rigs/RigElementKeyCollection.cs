using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigElementKeyCollection")]
	public partial class FRigElementKeyCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigElementKeyCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigElementKeyCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigElementKeyCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigElementKeyCollection A, FRigElementKeyCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigElementKeyCollection A, FRigElementKeyCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigElementKeyCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> Keys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __InBuffer);
				}
			}
		}

		private static uint __Keys = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}