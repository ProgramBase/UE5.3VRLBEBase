using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaMetadataItemsBPT")]
	public partial class FMediaMetadataItemsBPT : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaAssets.MediaMetadataItemsBPT");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMediaMetadataItemsBPT() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMediaMetadataItemsBPT() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMediaMetadataItemsBPT A, FMediaMetadataItemsBPT B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMediaMetadataItemsBPT A, FMediaMetadataItemsBPT B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMediaMetadataItemsBPT;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMediaMetadataItemBPT> Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(TArray<FMediaMetadataItemBPT>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Items, __InBuffer);
				}
			}
		}

		private static uint __Items = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}