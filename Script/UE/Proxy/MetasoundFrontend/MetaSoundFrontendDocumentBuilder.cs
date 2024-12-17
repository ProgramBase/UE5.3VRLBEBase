using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetaSoundFrontendDocumentBuilder")]
	public partial class FMetaSoundFrontendDocumentBuilder : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetaSoundFrontendDocumentBuilder");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundFrontendDocumentBuilder() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaSoundFrontendDocumentBuilder() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaSoundFrontendDocumentBuilder A, FMetaSoundFrontendDocumentBuilder B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundFrontendDocumentBuilder A, FMetaSoundFrontendDocumentBuilder B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundFrontendDocumentBuilder;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TScriptInterface<IMetaSoundDocumentInterface> DocumentInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DocumentInterface, __ReturnBuffer);

					return *(TScriptInterface<IMetaSoundDocumentInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DocumentInterface, __InBuffer);
				}
			}
		}

		private static uint __DocumentInterface = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}