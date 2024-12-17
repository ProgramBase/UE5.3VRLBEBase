using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.FoliageTypeInfo")]
	public partial class FFoliageTypeInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MegascansPlugin.FoliageTypeInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFoliageTypeInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFoliageTypeInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFoliageTypeInfo A, FFoliageTypeInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFoliageTypeInfo A, FFoliageTypeInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFoliageTypeInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString path
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __path, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __path, __InBuffer);
				}
			}
		}

		private static uint __path = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}