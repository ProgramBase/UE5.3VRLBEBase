using Script.CoreUObject;
using Script.Library;
using Script.CoreOnline;

namespace Script.Engine
{
	[PathName("/Script/Engine.UniqueNetIdRepl")]
	public partial class FUniqueNetIdRepl : FUniqueNetIdWrapper, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.UniqueNetIdRepl");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUniqueNetIdRepl()
		{
		}

		public static bool operator ==(FUniqueNetIdRepl A, FUniqueNetIdRepl B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUniqueNetIdRepl A, FUniqueNetIdRepl B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUniqueNetIdRepl;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> ReplicationBytes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplicationBytes, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplicationBytes, __InBuffer);
				}
			}
		}

		private static uint __ReplicationBytes = 0;

	}
}