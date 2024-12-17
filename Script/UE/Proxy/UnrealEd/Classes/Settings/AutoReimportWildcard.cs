using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AutoReimportWildcard")]
	public partial class FAutoReimportWildcard : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.AutoReimportWildcard");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutoReimportWildcard() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutoReimportWildcard() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutoReimportWildcard A, FAutoReimportWildcard B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutoReimportWildcard A, FAutoReimportWildcard B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutoReimportWildcard;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Wildcard
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Wildcard, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Wildcard, __InBuffer);
				}
			}
		}

		public bool bInclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bInclude, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bInclude, __InBuffer);
				}
			}
		}

		private static uint __Wildcard = 0;

		private static uint __bInclude = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}