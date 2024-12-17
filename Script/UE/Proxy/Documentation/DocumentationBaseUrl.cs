using Script.CoreUObject;
using Script.Library;

namespace Script.Documentation
{
	[PathName("/Script/Documentation.DocumentationBaseUrl")]
	public partial class FDocumentationBaseUrl : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Documentation.DocumentationBaseUrl");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDocumentationBaseUrl() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDocumentationBaseUrl() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDocumentationBaseUrl A, FDocumentationBaseUrl B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDocumentationBaseUrl A, FDocumentationBaseUrl B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDocumentationBaseUrl;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Id
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Id, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Id, __InBuffer);
				}
			}
		}

		public FString Url
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Url, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Url, __InBuffer);
				}
			}
		}

		private static uint __Id = 0;

		private static uint __Url = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}