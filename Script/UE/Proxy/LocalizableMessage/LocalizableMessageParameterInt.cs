using Script.CoreUObject;
using Script.Library;

namespace Script.LocalizableMessage
{
	[PathName("/Script/LocalizableMessage.LocalizableMessageParameterInt")]
	public partial class FLocalizableMessageParameterInt : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LocalizableMessage.LocalizableMessageParameterInt");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizableMessageParameterInt() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizableMessageParameterInt() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizableMessageParameterInt A, FLocalizableMessageParameterInt B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizableMessageParameterInt A, FLocalizableMessageParameterInt B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizableMessageParameterInt;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public long Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(long*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(long*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}