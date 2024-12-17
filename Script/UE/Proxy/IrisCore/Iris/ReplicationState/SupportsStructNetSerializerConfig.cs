using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SupportsStructNetSerializerConfig")]
	public partial class FSupportsStructNetSerializerConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.SupportsStructNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSupportsStructNetSerializerConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSupportsStructNetSerializerConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSupportsStructNetSerializerConfig A, FSupportsStructNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSupportsStructNetSerializerConfig A, FSupportsStructNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSupportsStructNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName StructName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StructName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StructName, __InBuffer);
				}
			}
		}

		public bool bCanUseStructNetSerializer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCanUseStructNetSerializer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCanUseStructNetSerializer, __InBuffer);
				}
			}
		}

		private static uint __StructName = 0;

		private static uint __bCanUseStructNetSerializer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}