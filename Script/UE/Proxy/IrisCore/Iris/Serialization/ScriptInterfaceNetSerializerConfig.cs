using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ScriptInterfaceNetSerializerConfig")]
	public partial class FScriptInterfaceNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.ScriptInterfaceNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScriptInterfaceNetSerializerConfig()
		{
		}

		public static bool operator ==(FScriptInterfaceNetSerializerConfig A, FScriptInterfaceNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScriptInterfaceNetSerializerConfig A, FScriptInterfaceNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScriptInterfaceNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UObject> InterfaceClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceClass, __InBuffer);
				}
			}
		}

		private static uint __InterfaceClass = 0;

	}
}