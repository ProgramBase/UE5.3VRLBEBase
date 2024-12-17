using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.ElementID")]
	public partial class FElementID : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.ElementID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FElementID() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FElementID() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FElementID A, FElementID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FElementID A, FElementID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FElementID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int IDValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IDValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IDValue, __InBuffer);
				}
			}
		}

		private static uint __IDValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}