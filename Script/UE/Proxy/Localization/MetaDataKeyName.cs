using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.MetaDataKeyName")]
	public partial class FMetaDataKeyName : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.MetaDataKeyName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaDataKeyName() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaDataKeyName() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaDataKeyName A, FMetaDataKeyName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaDataKeyName A, FMetaDataKeyName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaDataKeyName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}