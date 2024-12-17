using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PropertyEditTestTextStruct")]
	public partial class FPropertyEditTestTextStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.PropertyEditTestTextStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyEditTestTextStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyEditTestTextStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyEditTestTextStruct A, FPropertyEditTestTextStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyEditTestTextStruct A, FPropertyEditTestTextStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyEditTestTextStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FText NormalProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NormalProperty, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NormalProperty, __InBuffer);
				}
			}
		}

		private static uint __NormalProperty = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}