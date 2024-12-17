using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.StructMetadata")]
	public partial class FStructMetadata : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.StructMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStructMetadata() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStructMetadata() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStructMetadata A, FStructMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStructMetadata A, FStructMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStructMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, FMetadataSet> Fields
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Fields, __ReturnBuffer);

					return *(TMap<FName, FMetadataSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Fields, __InBuffer);
				}
			}
		}

		public FMetadataSet StructMetadata
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StructMetadata, __ReturnBuffer);

					return *(FMetadataSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StructMetadata, __InBuffer);
				}
			}
		}

		private static uint __Fields = 0;

		private static uint __StructMetadata = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}