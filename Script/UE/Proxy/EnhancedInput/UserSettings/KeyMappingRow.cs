using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.KeyMappingRow")]
	public partial class FKeyMappingRow : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.KeyMappingRow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FKeyMappingRow() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FKeyMappingRow() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FKeyMappingRow A, FKeyMappingRow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FKeyMappingRow A, FKeyMappingRow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FKeyMappingRow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FPlayerKeyMapping> Mappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mappings, __ReturnBuffer);

					return *(TSet<FPlayerKeyMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mappings, __InBuffer);
				}
			}
		}

		private static uint __Mappings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}