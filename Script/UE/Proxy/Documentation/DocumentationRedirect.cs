using Script.CoreUObject;
using Script.Library;

namespace Script.Documentation
{
	[PathName("/Script/Documentation.DocumentationRedirect")]
	public partial class FDocumentationRedirect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Documentation.DocumentationRedirect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDocumentationRedirect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDocumentationRedirect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDocumentationRedirect A, FDocumentationRedirect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDocumentationRedirect A, FDocumentationRedirect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDocumentationRedirect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString From
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __From, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __From, __InBuffer);
				}
			}
		}

		public FDocumentationUrl ToUrl
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ToUrl, __ReturnBuffer);

					return *(FDocumentationUrl*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ToUrl, __InBuffer);
				}
			}
		}

		private static uint __From = 0;

		private static uint __ToUrl = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}