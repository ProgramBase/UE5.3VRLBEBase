using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.MetaDataKeyGatherSpecification")]
	public partial class FMetaDataKeyGatherSpecification : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.MetaDataKeyGatherSpecification");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaDataKeyGatherSpecification() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaDataKeyGatherSpecification() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaDataKeyGatherSpecification A, FMetaDataKeyGatherSpecification B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaDataKeyGatherSpecification A, FMetaDataKeyGatherSpecification B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaDataKeyGatherSpecification;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetaDataKeyName MetaDataKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetaDataKey, __ReturnBuffer);

					return *(FMetaDataKeyName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetaDataKey, __InBuffer);
				}
			}
		}

		public FString TextNamespace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextNamespace, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextNamespace, __InBuffer);
				}
			}
		}

		public FMetaDataTextKeyPattern TextKeyPattern
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextKeyPattern, __ReturnBuffer);

					return *(FMetaDataTextKeyPattern*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextKeyPattern, __InBuffer);
				}
			}
		}

		private static uint __MetaDataKey = 0;

		private static uint __TextNamespace = 0;

		private static uint __TextKeyPattern = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}