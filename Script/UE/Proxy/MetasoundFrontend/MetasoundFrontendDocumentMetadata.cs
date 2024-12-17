using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendDocumentMetadata")]
	public partial class FMetasoundFrontendDocumentMetadata : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendDocumentMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendDocumentMetadata() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendDocumentMetadata() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendDocumentMetadata A, FMetasoundFrontendDocumentMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendDocumentMetadata A, FMetasoundFrontendDocumentMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendDocumentMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendVersion Version
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Version, __ReturnBuffer);

					return *(FMetasoundFrontendVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Version, __InBuffer);
				}
			}
		}

		private static uint __Version = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}