using Script.CoreUObject;
using Script.Library;
using Script.StructUtils;

namespace Script.LocalizableMessage
{
	[PathName("/Script/LocalizableMessage.LocalizableMessageParameterEntry")]
	public partial class FLocalizableMessageParameterEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LocalizableMessage.LocalizableMessageParameterEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizableMessageParameterEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizableMessageParameterEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizableMessageParameterEntry A, FLocalizableMessageParameterEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizableMessageParameterEntry A, FLocalizableMessageParameterEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizableMessageParameterEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Key
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Key, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Key, __InBuffer);
				}
			}
		}

		public FInstancedStruct Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FInstancedStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Key = 0;

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}