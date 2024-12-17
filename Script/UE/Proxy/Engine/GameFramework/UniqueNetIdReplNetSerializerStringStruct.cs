using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.UniqueNetIdReplNetSerializerStringStruct")]
	public partial class FUniqueNetIdReplNetSerializerStringStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.UniqueNetIdReplNetSerializerStringStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUniqueNetIdReplNetSerializerStringStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUniqueNetIdReplNetSerializerStringStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUniqueNetIdReplNetSerializerStringStruct A, FUniqueNetIdReplNetSerializerStringStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUniqueNetIdReplNetSerializerStringStruct A, FUniqueNetIdReplNetSerializerStringStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUniqueNetIdReplNetSerializerStringStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString String
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __String, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __String, __InBuffer);
				}
			}
		}

		private static uint __String = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}