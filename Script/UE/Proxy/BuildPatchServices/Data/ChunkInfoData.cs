using Script.CoreUObject;
using Script.Library;

namespace Script.BuildPatchServices
{
	[PathName("/Script/BuildPatchServices.ChunkInfoData")]
	public partial class FChunkInfoData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BuildPatchServices.ChunkInfoData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChunkInfoData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChunkInfoData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChunkInfoData A, FChunkInfoData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChunkInfoData A, FChunkInfoData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChunkInfoData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid Guid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Guid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Guid, __InBuffer);
				}
			}
		}

		public ulong Hash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __InBuffer);
				}
			}
		}

		public FSHAHashData ShaHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShaHash, __ReturnBuffer);

					return *(FSHAHashData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShaHash, __InBuffer);
				}
			}
		}

		public long FileSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FileSize, __ReturnBuffer);

					return *(long*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(long*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FileSize, __InBuffer);
				}
			}
		}

		public byte GroupNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GroupNumber, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GroupNumber, __InBuffer);
				}
			}
		}

		private static uint __Guid = 0;

		private static uint __Hash = 0;

		private static uint __ShaHash = 0;

		private static uint __FileSize = 0;

		private static uint __GroupNumber = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}