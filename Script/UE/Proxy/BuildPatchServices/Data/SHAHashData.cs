using Script.CoreUObject;
using Script.Library;

namespace Script.BuildPatchServices
{
	[PathName("/Script/BuildPatchServices.SHAHashData")]
	public partial class FSHAHashData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BuildPatchServices.SHAHashData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSHAHashData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSHAHashData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSHAHashData A, FSHAHashData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSHAHashData A, FSHAHashData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSHAHashData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte Hash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __InBuffer);
				}
			}
		}

		private static uint __Hash = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}