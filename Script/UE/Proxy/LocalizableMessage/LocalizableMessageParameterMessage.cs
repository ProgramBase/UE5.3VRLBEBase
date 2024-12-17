using Script.CoreUObject;
using Script.Library;

namespace Script.LocalizableMessage
{
	[PathName("/Script/LocalizableMessage.LocalizableMessageParameterMessage")]
	public partial class FLocalizableMessageParameterMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LocalizableMessage.LocalizableMessageParameterMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizableMessageParameterMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizableMessageParameterMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizableMessageParameterMessage A, FLocalizableMessageParameterMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizableMessageParameterMessage A, FLocalizableMessageParameterMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizableMessageParameterMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLocalizableMessage Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FLocalizableMessage*)__ReturnBuffer;
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

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}