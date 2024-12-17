using Script.CoreUObject;
using Script.Library;

namespace Script.Documentation
{
	[PathName("/Script/Documentation.DocumentationUrl")]
	public partial class FDocumentationUrl : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Documentation.DocumentationUrl");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDocumentationUrl() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDocumentationUrl() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDocumentationUrl A, FDocumentationUrl B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDocumentationUrl A, FDocumentationUrl B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDocumentationUrl;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Link
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Link, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Link, __InBuffer);
				}
			}
		}

		public FString BaseUrlId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseUrlId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseUrlId, __InBuffer);
				}
			}
		}

		private static uint __Link = 0;

		private static uint __BaseUrlId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}