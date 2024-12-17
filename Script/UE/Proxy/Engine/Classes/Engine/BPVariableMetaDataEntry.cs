using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BPVariableMetaDataEntry")]
	public partial class FBPVariableMetaDataEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BPVariableMetaDataEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBPVariableMetaDataEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBPVariableMetaDataEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBPVariableMetaDataEntry A, FBPVariableMetaDataEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBPVariableMetaDataEntry A, FBPVariableMetaDataEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBPVariableMetaDataEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName DataKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataKey, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataKey, __InBuffer);
				}
			}
		}

		public FString DataValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataValue, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataValue, __InBuffer);
				}
			}
		}

		private static uint __DataKey = 0;

		private static uint __DataValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}