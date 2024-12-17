using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.MetadataConfig")]
	public partial class FMetadataConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.MetadataConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetadataConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetadataConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetadataConfig A, FMetadataConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetadataConfig A, FMetadataConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetadataConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, FStructMetadata> Classes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Classes, __ReturnBuffer);

					return *(TMap<FName, FStructMetadata>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Classes, __InBuffer);
				}
			}
		}

		private static uint __Classes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}